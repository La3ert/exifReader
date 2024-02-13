using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompactExifLib;

namespace ExifReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String filePath;
        private void button1_Click_1(object sender, EventArgs e)
        {
            ExifData TestExif;
            DateTime DateTaken;
            
            
            OpenFileDialog selectImage = new OpenFileDialog()
            {
                DefaultExt = "jpg",
                Filter = "JPEG Files|*.jpg",
                FilterIndex = 2
            };
            
            if (selectImage.ShowDialog() == DialogResult.OK)
            {
                filePath = selectImage.FileName;
            }
           
            TestExif = new ExifData(filePath);
            if (TestExif.GetTagValue(ExifTag.DateTimeOriginal, out DateTaken))
            {
                lblDate.Text = DateTaken.ToString();
            }
            else
            {
                lblDate.Text = "No Date Found";
            }
            if (TestExif.GetTagValue(ExifTag.Make, out string make, StrCoding.Utf8))
            {
                lblMake.Text = make;
            }
            else
            {
                lblMake.Text = "No Make Found";
            }
            if (TestExif.GetTagValue(ExifTag.Model, out string model, StrCoding.Utf8))
            {
                lblModel.Text = model;
            }
            else
            {
                lblModel.Text = "No Model Found";
            }
            if(TestExif.GetTagValue(ExifTag.Orientation, out int orientation))
            {
                lblOrientation.Text = orientation.ToString();
            }
            else
            {
                lblOrientation.Text = "No Orientation Found";
            }
        }
        
        
        
        private void bttn_Change_Make_Click(object sender, EventArgs e)
        {
            string changeMake = txtBox_ChangeMake.Text;
            ExifData TestExif = new ExifData(filePath);
            TestExif.SetTagValue(ExifTag.Make, changeMake, StrCoding.Utf8);
            if (TestExif.GetTagValue(ExifTag.Make, out string make, StrCoding.Utf8))
            {
                lblMake.Text = make;
            }
            txtBox_ChangeMake.Clear();
        }

        private void bttn_Change_Orientation_Click(object sender, EventArgs e)
        {
            string value = txtBox_ChangeOrientation.Text;
            int changeOrientation = int.Parse(value);
            ExifData TestExif = new ExifData(filePath);
            TestExif.SetTagValue(ExifTag.Orientation, changeOrientation, ExifTagType.UShort);
            if (TestExif.GetTagValue(ExifTag.Orientation, out int orientation))
            {
                lblOrientation.Text = orientation.ToString();
            }

            TestExif.Save(null, 0);
            txtBox_ChangeOrientation.Clear();
        }

        private void bttn_Change_Model_Click(object sender, EventArgs e)
        {
            string changeModel = txtBox_ChangeModel.Text;
            ExifData TestExif = new ExifData(filePath);
            TestExif.SetTagValue(ExifTag.Model, changeModel, StrCoding.Utf8);
            if (TestExif.GetTagValue(ExifTag.Model, out string model, StrCoding.Utf8))
            {
                lblModel.Text = model;
            }
            txtBox_ChangeModel.Clear();
        }

        private void bttn_Change_Date_Click(object sender, EventArgs e)
        {
            ExifData TestExif = new ExifData(filePath);
            DateTime DateTaken;
            TestExif.GetTagValue(ExifTag.DateTimeOriginal, out DateTaken);
            string value = txtBox_ChangeDate.Text;
            int changeDate = Convert.ToInt32(value);
            while (changeDate > 23)
            {
                DateTaken.AddDays(1);
                TestExif.SetTagValue(ExifTag.DateTimeOriginal, DateTaken);
                TestExif.Save();
                changeDate -= 24;
            }

            DateTaken.AddHours(changeDate);
            TestExif.SetTagValue(ExifTag.DateTimeOriginal, DateTaken);
            TestExif.Save();
            lblDate.Text = DateTaken.ToString();
            
            txtBox_ChangeDate.Clear();
        }
    }
}