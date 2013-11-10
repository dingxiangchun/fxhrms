using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ActiveX5
{
    [Guid("ebca8d01-6b80-4e94-84de-c1c5ae15e564")]
    public partial class dirselect : Component, IObjectSafety
    {
        private string strSelectedDir = string.Empty;
        private string[] strAllFiles = null;
        private int iFilesCount = 0;

        public dirselect()
        {
            InitializeComponent();
        }

        public dirselect(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// 选择文件夹
        /// </summary>
        /// <returns>是否选择了</returns>
        public string showDlg()
        {
            folderBrowserDialog1.Description = "请选择需要上传的文件夹：";
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                strSelectedDir = folderBrowserDialog1.SelectedPath;

                strAllFiles = System.IO.Directory.GetFiles(strSelectedDir, "*", System.IO.SearchOption.AllDirectories);

                iFilesCount = strAllFiles.Length;
                return strSelectedDir;
            }

            return string.Empty;
        }

        /// <summary>
        /// 返回选择的文件夹
        /// </summary>
        /// <returns></returns>
        public string GetSelctedDir()
        {
            return strSelectedDir;
        }

        /// <summary>
        /// 返回该文件夹下所有文件数目
        /// </summary>
        /// <returns></returns>
        public int GetFilesCount()
        {
            return iFilesCount;
        }

        ////返回该文件夹下所有文件路径
        //public string[] GetFiles()
        //{
        //    string[] FileInfos = System.IO.Directory.GetFiles(strSelectedDir, "*", System.IO.SearchOption.AllDirectories);
        //    return FileInfos;    
        //}

        //返回该文件夹下所有文件路径中的第ige
        public string GetFile(int i)
        {
            return strAllFiles[i];
        }


        #region IObjectSafety 成员

        public void GetInterfaceSafetyOptions(ref Guid riid, ref int pdwSupportedOptions, ref int pdwEnabledOptions)
        {
            pdwSupportedOptions = 1;
            pdwEnabledOptions = 2;
        }

        public void SetInterfaceSafetyOptions(ref Guid riid, int dwOptionSetMask, int dwEnabledOptions)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
