using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office.Interop.Word;

namespace OfficeControl
{
    public class CreateWordByTemplate
    {
        public CreateWordByTemplate()
        { }
         private Microsoft.Office.Interop.Word.Document wDoc = null;   
        private Microsoft.Office.Interop.Word.Application wApp = null;   
        public Microsoft.Office.Interop.Word.Document Document   
        {   
            get { return wDoc; }   
            set { wDoc = value; }   
        }   
  
        public Microsoft.Office.Interop.Word.Application Application   
        {   
            get { return wApp; }   
            set { wApp = value; }   
        }  
        #region ��ģ�崴���µ�Word�ĵ�   
        /// <summary>   
        /// ��ģ�崴���µ�Word�ĵ�   
        /// </summary>   
        /// <param name="templateName">ģ���ļ���</param>   
        /// <returns></returns>   
        public bool CreateNewWordDocument(string templateName)   
        {   
            try  
            {   
                return CreateNewWordDocument(templateName, ref wDoc, ref wApp);   
            }   
            catch (Exception ex)   
            {   
                throw ex;   
            }   
        }  
        #endregion  
 
        #region ��ģ�崴���µ�Word�ĵ�,���ҷ��ض���Document,Application   
        /// <summary>   
        /// ��ģ�崴���µ�Word�ĵ���   
        /// </summary>   
        /// <param name="templateName">ģ���ļ���</param>   
        /// <param name="wDoc">���ص�Word.Document����</param>   
        /// <param name="WApp">���ص�Word.Application����</param>   
        /// <returns></returns>   
        public static bool CreateNewWordDocument(string templateName, ref Microsoft.Office.Interop.Word.Document wDoc, ref  Microsoft.Office.Interop.Word.Application WApp)   
        {   
            Microsoft.Office.Interop.Word.Document thisDocument = null;
            Microsoft.Office.Interop.Word.Application thisApplication = new ApplicationClass();   
            thisApplication.Visible = false;   
            thisApplication.Caption = "";   
            thisApplication.Options.CheckSpellingAsYouType = false;   
            thisApplication.Options.CheckGrammarAsYouType = false;   
  
            Object Template = templateName;// Optional Object. The name of the template to be used for the new document. If this argument is omitted, the Normal template is used.   
            Object NewTemplate = false;// Optional Object. True to open the document as a template. The default value is False.   
            Object DocumentType = Microsoft.Office.Interop.Word.WdNewDocumentType.wdNewBlankDocument; // Optional Object. Can be one of the following WdNewDocumentType constants: wdNewBlankDocument, wdNewEmailMessage, wdNewFrameset, or wdNewWebPage. The default constant is wdNewBlankDocument.   
            Object Visible = true;//Optional Object. True to open the document in a visible window. If this value is False, Microsoft Word opens the document but sets the Visible property of the document window to False. The default value is True.   
  
            try  
            {   
                Microsoft.Office.Interop.Word.Document wordDoc = thisApplication.Documents.Add(ref Template, ref NewTemplate, ref DocumentType, ref Visible);   
  
                thisDocument = wordDoc;   
                wDoc = wordDoc;   
                WApp = thisApplication;   
                return true;   
            }   
            catch (Exception ex)   
            {   
                string err = string.Format("����Word�ĵ���������ԭ��{0}", ex.Message);   
                throw new Exception(err, ex);   
            }   
        }  
        #endregion  
 
        #region �ĵ����Ϊ�����ļ���   
        /// <summary>   
        /// �ĵ����Ϊ�����ļ���   
        /// </summary>   
        /// <param name="fileName">�ļ���</param>   
        /// <param name="wDoc">Document����</param>   
        public bool SaveAs(string fileName)   
        {   
            try  
            {   
                return SaveAs(fileName, wDoc);   
            }   
            catch (Exception ex)   
            {   
                throw ex;   
            }   
        }  
        #endregion  
 
        #region �ĵ����Ϊ�����ļ���   
        /// <summary>   
        /// �ĵ����Ϊ�����ļ���   
        /// </summary>   
        /// <param name="fileName">�ļ���</param>   
        /// <param name="wDoc">Document����</param>   
        public static bool SaveAs(string fileName, Microsoft.Office.Interop.Word.Document wDoc)   
        {   
            Object FileName = fileName; // �ĵ������ơ�Ĭ��ֵ�ǵ�ǰ�ļ��������ļ���������ĵ�����ǰû�б��������ʹ��Ĭ�����ƣ����磬Doc1.doc��������Ѿ����ھ���ָ���ļ������ĵ�������ڲ�����ʾ�û�������¸�д�ĵ���   
            Object FileFormat = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocument; // �ĵ��ı����ʽ���������κ� WdSaveFormat ֵ��Ҫ����һ�ָ�ʽ�����ĵ�����Ϊ SaveFormat ����ָ���ʵ���ֵ��   
            Object LockComments = false; // ���Ϊ true���������ĵ��Խ���ע�͡�Ĭ��ֵΪ false��   
            Object Password = System.Type.Missing; // �������ĵ��������ַ���������μ�����ı�ע����   
            Object AddToRecentFiles = false; // ���Ϊ true���򽫸��ĵ���ӵ����ļ����˵������ʹ�õ��ļ��б��С�Ĭ��ֵΪ true��   
            Object WritePassword = System.Type.Missing; // ����������ļ��������ĵ������ַ���������μ�����ı�ע����   
            Object ReadOnlyRecommended = false; // ���Ϊ true������ Microsoft Office Word �ڴ��ĵ�ʱ����ֻ��״̬��Ĭ��ֵΪ false��   
            Object EmbedTrueTypeFonts = false; //���Ϊ true���� TrueType �������ĵ�һ�𱣴档���ʡ�ԵĻ����� EmbedTrueTypeFonts �����ٶ� EmbedTrueTypeFonts ���Ե�ֵ��   
            Object SaveNativePictureFormat = true; // ���ͼ���Ǵ���һ��ƽ̨�����磬Macintosh������ģ��� true ��ʾ�����浼��ͼ�ε� Windows �汾��   
            Object SaveFormsData = false; // ���Ϊ true�����û��ڴ�����������������Ϊ���ݼ�¼��   
            Object SaveAsAOCELetter = false; // ����ĵ��������ʼ������� true ��ʾ�Ὣ�ĵ����Ϊ AOCE �ź����ʼ��������б��棩��   
            Object Encoding = System.Type.Missing; // MsoEncoding��Ҫ�������Ϊ�����ı��ļ����ĵ��Ĵ���ҳ���ַ�����Ĭ��ֵ��ϵͳ����ҳ��   
            Object InsertLineBreaks = true; // ����ĵ����Ϊ�ı��ļ����� true ��ʾ��ÿ���ı�ĩβ������з���   
            Object AllowSubstitutions = false; //����ĵ����Ϊ�ı��ļ����� true ���� Word ��ĳЩ�����滻Ϊ�����֮���Ƶ��ı������磬����Ȩ������ʾΪ (c)��Ĭ��ֵΪ false��   
            Object LineEnding = Microsoft.Office.Interop.Word.WdLineEndingType.wdCRLF;// Word �����Ϊ�ı��ļ����ĵ��б�Ƿ��з��ͻ��η����������κ� WdLineEndingType ֵ��   
            Object AddBiDiMarks = true;//���Ϊ true����������ļ���ӿ����ַ����Ա㱣��ԭʼ�ĵ����ı���˫�򲼾֡�   
            try  
            {   
                wDoc.SaveAs(ref FileName, ref FileFormat, ref LockComments, ref Password, ref AddToRecentFiles, ref WritePassword   
                        , ref ReadOnlyRecommended, ref EmbedTrueTypeFonts, ref SaveNativePictureFormat   
                        , ref SaveFormsData, ref SaveAsAOCELetter, ref Encoding, ref InsertLineBreaks, ref AllowSubstitutions   
                        , ref LineEnding, ref AddBiDiMarks);   
                return true;   
            }   
            catch (Exception ex)   
            {   
                string err = string.Format("����ļ���������ԭ��{0}", ex.Message);   
                throw new Exception(err, ex);   
            }   
        }  
        #endregion  
 
        #region �ر��ĵ�   
        /// <summary>   
        /// �ر��ĵ�   
        /// </summary>   
        public void Close()   
        {   
            Close(wDoc, wApp);   
            wDoc = null;   
            wApp = null;   
        }  
        #endregion  
 
        #region �ر��ĵ�   
        /// <summary>   
        /// �ر��ĵ�   
        /// </summary>   
        /// <param name="wDoc">Document����</param>   
        /// <param name="WApp">Application����</param>   
        public static void Close(Microsoft.Office.Interop.Word.Document wDoc, Microsoft.Office.Interop.Word.Application WApp)   
        {   
            Object SaveChanges = Microsoft.Office.Interop.Word.WdSaveOptions.wdSaveChanges;// ָ���ĵ��ı������������������ WdSaveOptions ֵ֮һ��wdDoNotSaveChanges��wdPromptToSaveChanges �� wdSaveChanges��   
            Object OriginalFormat = Microsoft.Office.Interop.Word.WdOriginalFormat.wdOriginalDocumentFormat;// ָ���ĵ��ı����ʽ������������ WdOriginalFormat ֵ֮һ��wdOriginalDocumentFormat��wdPromptUser �� wdWordDocument��   
            Object RouteDocument = false;// ���Ϊ true�����ĵ����͸���һ���ռ��ˡ����û��Ϊ�ĵ����Ӵ�������������Դ˲�����   
            try  
            {   
                if (wDoc != null) wDoc.Close(ref SaveChanges, ref OriginalFormat, ref RouteDocument);   
                if (WApp != null) WApp.Quit(ref SaveChanges, ref OriginalFormat, ref RouteDocument);   
            }   
            catch (Exception ex)   
            {   
                throw ex;   
            }   
        }  
        #endregion  
 
        #region �����ǩ   
        /// <summary>   
        /// �����ǩ   
        /// </summary>   
        /// <param name="bookmark">��ǩ</param>   
        /// <param name="value">ֵ</param>   
        public void Replace(string bookmark, string value)   
        {   
            try  
            {   
                object bkObj = bookmark;   
                if (wApp.ActiveDocument.Bookmarks.Exists(bookmark) == true)   
                {   
                    wApp.ActiveDocument.Bookmarks.get_Item(ref bkObj).Select();   
                }   
                else return;   
                wApp.Selection.TypeText(value);   
            }   
            catch (Exception ex)   
            {   
                throw ex;   
            }   
        }  
        #endregion   
  
        public bool FindTable(string bookmarkTable)   
        {   
            try  
            {   
                object bkObj = bookmarkTable;   
                if (wApp.ActiveDocument.Bookmarks.Exists(bookmarkTable) == true)   
                {   
                    wApp.ActiveDocument.Bookmarks.get_Item(ref bkObj).Select();   
                    return true;   
                }   
                else  
                    return false;   
            }   
            catch (Exception ex)   
            {   
                throw ex;   
            }   
        }   
  
        public void MoveNextCell()   
        {   
            try  
            {   
                Object unit = Microsoft.Office.Interop.Word.WdUnits.wdCell;   
                Object count = 1;   
                wApp.Selection.Move(ref unit, ref count);   
            }   
            catch (Exception ex)   
            {   
                throw ex;   
            }   
        }

        public bool SetImage(string Imagepath,string bookmarkname)
        {
            foreach (Bookmark bm in wDoc.Bookmarks)
            {
                if (bm.Name == bookmarkname)
                {
                    bm.Select();
                    InlineShape li = wApp.Selection.InlineShapes.AddPicture(Imagepath);
                    Shape s = li.ConvertToShape();
                    //wDoc.Application.ActiveDocument.InlineShapes[1].Width = 100f;//ͼƬ���  
                    //wDoc.Application.ActiveDocument.InlineShapes[1].Height = 100f;//ͼƬ��� 
                    //��ͼƬ����Ϊ���ܻ�����  
                    s.WrapFormat.Type = WdWrapType.wdWrapSquare;  
                }
            }

            return true;
        }
  
        public void SetCellValue(string value)   
        {   
            try  
            {   
                wApp.Selection.TypeText(value);   
            }   
            catch (Exception ex)   
            {   
                throw ex;   
            }   
        }   
        public void MoveNextRow()   
        {   
            try  
            {   
                Object extend = Microsoft.Office.Interop.Word.WdMovementType.wdExtend;   
                Object unit = Microsoft.Office.Interop.Word.WdUnits.wdCell;   
                Object count = 1;   
                wApp.Selection.MoveRight(ref unit, ref count, ref extend);   
            }   
            catch (Exception ex)   
            {   
                throw ex;   
            }   
        }   
    }   
}
