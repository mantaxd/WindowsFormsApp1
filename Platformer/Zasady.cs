﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Zasady : Form
    {
        
        public Zasady()
        {
            InitializeComponent();
        }

        private void exitBoxClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
