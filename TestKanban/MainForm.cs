using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TestKanban.Infrastructure;
using TestKanban.Models;

namespace TestKanban
{
    public partial class MainForm : Form
    {
        private readonly IAppSettings appSettings;
        private readonly ILogger<MainForm> logger;

        public MainForm(IAppSettings appSettings, ILogger<MainForm> logger)
        {
            this.appSettings = appSettings;
            this.logger = logger;

            InitializeComponent();

            this.Text = appSettings.MainFormTitle;
        }
    }
}
