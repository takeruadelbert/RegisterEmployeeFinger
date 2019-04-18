using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libzkfpcsharp;
using RegisterEmployeeFinger.src.Class.Helper;
using RegisterEmployeeFinger.src.Class.CodeMessage;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using RegisterEmployeeFinger.src.Class.Miscellaneous;
using RegisterEmployeeFinger.src.Class.Forms;

namespace RegisterEmployeeFinger.src.Class.FingerprintDevice
{
    class Device : Form
    {
        static IntPtr mDevHandle = IntPtr.Zero;
        static IntPtr mDBHandle = IntPtr.Zero;
        static IntPtr FormHandle = IntPtr.Zero;
        bool bIsTimeToDie = false;
        bool IsRegister = false;
        bool bIdentify = true;
        static byte[] FPBuffer;
        static int RegisterCount = 0;
        const int REGISTER_FINGER_COUNT = 3;

        static byte[][] RegTmps = new byte[3][];
        static byte[] RegTmp = new byte[2048];
        static byte[] CapTmp = new byte[2048];

        static int cbCapTmp = 2048;
        static int cbRegTmp = 0;
        static int iFid = 1;

        private static int mfpWidth = 0;
        private static int mfpHeight = 0;
        private static int mfpDpi = 0;

        const int MESSAGE_CAPTURED_OK = 0x0400 + 6;

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        private TKHelper tk = new TKHelper();
        private ScanFinger scanFinger;

        public Device(ScanFinger scanFinger)
        {
            this.scanFinger = scanFinger;
            init();
        }
        
        public void init()
        {
            int ret = zkfperrdef.ZKFP_ERR_OK;
            if ((ret = zkfp2.Init()) == zkfperrdef.ZKFP_ERR_OK)
            {
                int nCount = zkfp2.GetDeviceCount() - 1;
                if (nCount > 0)
                {
                    Console.WriteLine(Code.SUCC_INIT_DEV);
                }
                else
                {
                    OpenDevice();
                }
            }
            else
            {
                Console.WriteLine(Code.ERR_INIT_FAILED + ", ret=" + ret + " !");
                OpenDevice();
            }
        }

        private void Device_Load(object sender, EventArgs e)
        {
            FormHandle = this.Handle;
        }

        public void OpenDevice()
        {
            try
            {
                int ret = zkfp.ZKFP_ERR_OK;
                if (IntPtr.Zero == (mDevHandle = zkfp2.OpenDevice(0)))
                {
                    Console.WriteLine(Code.ERR_OP_DEV_FAILED);
                    return;
                }
                if (IntPtr.Zero == (mDBHandle = zkfp2.DBInit()))
                {
                    Console.WriteLine(Code.ERR_INIT_DB_FAILED);
                    zkfp2.CloseDevice(mDevHandle);
                    mDevHandle = IntPtr.Zero;
                    return;
                }
                RegisterCount = 0;
                cbRegTmp = 0;
                iFid = 1;
                for (int i = 0; i < 3; i++)
                {
                    RegTmps[i] = new byte[2048];
                }
                byte[] paramValue = new byte[4];
                int size = 4;
                zkfp2.GetParameters(mDevHandle, 1, paramValue, ref size);
                zkfp2.ByteArray2Int(paramValue, ref mfpWidth);

                size = 4;
                zkfp2.GetParameters(mDevHandle, 2, paramValue, ref size);
                zkfp2.ByteArray2Int(paramValue, ref mfpHeight);

                FPBuffer = new byte[mfpWidth * mfpHeight];

                size = 4;
                zkfp2.GetParameters(mDevHandle, 3, paramValue, ref size);
                zkfp2.ByteArray2Int(paramValue, ref mfpDpi);

                Console.WriteLine("reader parameter, image width:" + mfpWidth + ", height:" + mfpHeight + ", dpi:" + mfpDpi + "\n");
                Console.WriteLine(Code.SUCC_OP_DEV + "\n");

                Thread captureThread = new Thread(new ThreadStart(DoCapture));
                captureThread.IsBackground = true;
                captureThread.Start();

                bIsTimeToDie = false;
            }
            catch (Exception ex)
            {
                zkfp2.Terminate();
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        private void DoCapture()
        {
            while (!bIsTimeToDie)
            {
                cbCapTmp = 2048;
                int ret = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
                if (ret == zkfp.ZKFP_ERR_OK)
                {
                    SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero);
                    CaptureDataFingerpint(MESSAGE_CAPTURED_OK);
                }
                Thread.Sleep(200);
            }
        }

        private void CaptureDataFingerpint(int message)
        {
            switch (message)
            {
                case MESSAGE_CAPTURED_OK:
                    {
                        MemoryStream ms = new MemoryStream();
                        BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, ref ms);
                        Bitmap bmp = new Bitmap(ms);

                        // set image to Scan Finger's Form
                        scanFinger.SetImage(bmp);
                        
                        String strShow = zkfp2.BlobToBase64(CapTmp, cbCapTmp);
                        Console.WriteLine(strShow);

                        // set quality finger
                        string present_quality_finger = tk.CalculatePercentageTemplateFingerprint(strShow.Length);
                        scanFinger.SetPresentQuality(present_quality_finger);
                    }
                    break;
                default:
                    Console.WriteLine("Error : Invalid Data Fingerprint.");
                    break;
            }
        }

        public void CloseDevice()
        {
            bIsTimeToDie = true;
            Thread.Sleep(1000);
            zkfp2.CloseDevice(mDevHandle);
            Console.WriteLine(Code.SUCC_CL_DEV);
        }
    }
}
