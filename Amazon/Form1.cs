using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Amazon
{
    public partial class Form1 : Form
    {
        AmazonClass TestNow = new AmazonClass();
       
        // IWebDriver Browser;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            TestNow.startBrowser();
            TestNow.test();
         
            //Browser = new OpenQA.Selenium.Chrome.ChromeDriver("C:\\discD\\SeleniumChrome");

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TestNow.closeBrowser();
                       
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TestNow.StartWork();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestNow.closeBrowser();
        }
    }
}
