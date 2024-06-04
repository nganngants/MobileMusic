using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileMusic.ucComponents
{
    public partial class ucComment : UserControl
    {
        public ucComment()
        {
            InitializeComponent();
        }
        public ucComment(string display_name, string comment, DateTime cmt_time, int score)
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("ucComment: " + display_name + " " + comment + " " + cmt_time);
            this.lbName.Text = display_name;
            this.lbComment.Text = comment;
            this.lbTime.Text = cmt_time.ToString();

            // Set star rating
            if (score >= 1) this.star1.BackgroundImage = Properties.Resources.star_filled;
            if (score >= 2) this.star2.BackgroundImage = Properties.Resources.star_filled;
            if (score >= 3) this.star3.BackgroundImage = Properties.Resources.star_filled;
            if (score >= 4) this.star4.BackgroundImage = Properties.Resources.star_filled;
            if (score >= 5) this.star5.BackgroundImage = Properties.Resources.star_filled;
        }

    }
}
