using System;
using System.IO;
using System.Windows.Forms;

namespace CustomOpenFileDialog
{
    public class CustomOpenFileDialog
    {
        private OpenFileDialog _ofd;

        public string FileName => _ofd.FileName;

        public CustomOpenFileDialog(FilterType type)
        {
            _ofd = new OpenFileDialog();
            _ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _ofd.Title = "ファイル選択";
            switch (type)
            {
                case FilterType.CSV:
                    _ofd.Filter = "csvファイル(*.csv)| *.csv";
                    break;
                case FilterType.HTML:
                    _ofd.Filter = "htmlファイル(*.html)| *.html";
                    break;
            }

        }

        public DialogResult ShowDialog()
        {
            return _ofd.ShowDialog();
        }
    }

    public enum FilterType
    {
        HTML = 1,
        CSV
    }
}