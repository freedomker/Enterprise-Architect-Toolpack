using System;

using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace GlossaryManager {

	public class ColumnLinkTabPage : TabPage {

    private GlossaryManagerUI ui;
    
    public ColumnLinkTabPage(GlossaryManagerUI ui) : base() {
      this.ui   = ui;
      this.Text = "Column Links";
    }

  }
}