﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradedUnitProject
{
    class CustomDataGrid6 : DataGridView
    {
        private DockStyle dock = DockStyle.Fill;

       /* private DataGridViewColumnHeadersHeightSizeMode m_ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;


        private int m_columnHeadersHeight = 23;





        public new DataGridViewColumnHeadersHeightSizeMode ColumnHeadersHeightSizeMode
        {
            get => this.m_ColumnHeadersHeightSizeMode;
            set
            {
                this.m_ColumnHeadersHeightSizeMode = value;
                base.ColumnHeadersHeightSizeMode = this.m_ColumnHeadersHeightSizeMode;
            }
        }

        public new int ColumnHeadersHeight
        {
            get => this.m_columnHeadersHeight;
            set
            {
                this.m_columnHeadersHeight = value;
                base.ColumnHeadersHeight = this.m_columnHeadersHeight;
            }


        }*/

        public new DockStyle Dock
        {
            get => this.dock;
            set {
                this.dock = value;
                base.Dock = this.dock; }
        }


    }

}

    

