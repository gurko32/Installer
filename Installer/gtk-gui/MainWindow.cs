
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VPaned vpaned1;

	private global::Gtk.VBox vbox1;

	private global::Gtk.Frame frame1;

	private global::Gtk.Alignment GtkAlignment;

	private global::Gtk.Label GtkLabel;

	private global::Gtk.Frame frame2;

	private global::Gtk.Alignment GtkAlignment1;

	private global::Gtk.Label GtkLabel1;

	private global::Gtk.Alignment alignment1;

	private global::Gtk.EventBox eventbox2;

	private global::Gtk.Expander expander1;

	private global::Gtk.Label GtkLabel2;

	private global::Gtk.HBox hbox1;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TreeView treeview1;
    
	private global::Gtk.Notebook notebook1;

	private global::Gtk.Label label1;

	private global::Gtk.ScrolledWindow scrolledwindow1;

	private global::Gtk.Frame frame3;

	private global::Gtk.Alignment GtkAlignment2;

	private global::Gtk.Label GtkLabel3;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vpaned1 = new global::Gtk.VPaned();
		this.vpaned1.CanFocus = true;
		this.vpaned1.Name = "vpaned1";
		this.vpaned1.Position = 129;
		// Container child vpaned1.Gtk.Paned+PanedChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		this.frame1.Add(this.GtkAlignment);
		this.GtkLabel = new global::Gtk.Label();
		this.GtkLabel.Name = "GtkLabel";
		this.GtkLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>GtkFrame</b>");
		this.GtkLabel.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel;
		this.vbox1.Add(this.frame1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame1]));
		w2.Position = 0;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame2 = new global::Gtk.Frame();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		this.frame2.Add(this.GtkAlignment1);
		this.GtkLabel1 = new global::Gtk.Label();
		this.GtkLabel1.Name = "GtkLabel1";
		this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString("<b>GtkFrame</b>");
		this.GtkLabel1.UseMarkup = true;
		this.frame2.LabelWidget = this.GtkLabel1;
		this.vbox1.Add(this.frame2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame2]));
		w4.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
		this.alignment1.Name = "alignment1";
		// Container child alignment1.Gtk.Container+ContainerChild
		this.eventbox2 = new global::Gtk.EventBox();
		this.eventbox2.Name = "eventbox2";
		// Container child eventbox2.Gtk.Container+ContainerChild
		this.expander1 = new global::Gtk.Expander(null);
		this.expander1.CanFocus = true;
		this.expander1.Name = "expander1";
		this.GtkLabel2 = new global::Gtk.Label();
		this.GtkLabel2.Name = "GtkLabel2";
		this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString("GtkExpander");
		this.GtkLabel2.UseUnderline = true;
		this.expander1.LabelWidget = this.GtkLabel2;
		this.eventbox2.Add(this.expander1);
		this.alignment1.Add(this.eventbox2);
		this.vbox1.Add(this.alignment1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.alignment1]));
		w7.Position = 2;
		this.vpaned1.Add(this.vbox1);
		global::Gtk.Paned.PanedChild w8 = ((global::Gtk.Paned.PanedChild)(this.vpaned1[this.vbox1]));
		w8.Resize = false;
		// Container child vpaned1.Gtk.Paned+PanedChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.treeview1 = new global::Gtk.TreeView();
		this.treeview1.CanFocus = true;
		this.treeview1.Name = "treeview1";
		this.GtkScrolledWindow.Add(this.treeview1);
		this.hbox1.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.GtkScrolledWindow]));
		w10.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.notebook1 = new global::Gtk.Notebook();
		this.notebook1.CanFocus = true;
		this.notebook1.Name = "notebook1";
		this.notebook1.CurrentPage = 0;
		// Notebook tab
		global::Gtk.Label w11 = new global::Gtk.Label();
		w11.Visible = true;
		this.notebook1.Add(w11);
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("page1");
		this.notebook1.SetTabLabel(w11, this.label1);
		this.label1.ShowAll();
		this.hbox1.Add(this.notebook1);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.notebook1]));
		w12.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
		this.scrolledwindow1.CanFocus = true;
		this.scrolledwindow1.Name = "scrolledwindow1";
		this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow1.Gtk.Container+ContainerChild
		global::Gtk.Viewport w13 = new global::Gtk.Viewport();
		w13.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.frame3 = new global::Gtk.Frame();
		this.frame3.Name = "frame3";
		this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame3.Gtk.Container+ContainerChild
		this.GtkAlignment2 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment2.Name = "GtkAlignment2";
		this.GtkAlignment2.LeftPadding = ((uint)(12));
		this.frame3.Add(this.GtkAlignment2);
		this.GtkLabel3 = new global::Gtk.Label();
		this.GtkLabel3.Name = "GtkLabel3";
		this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString("<b>GtkFrame</b>");
		this.GtkLabel3.UseMarkup = true;
		this.frame3.LabelWidget = this.GtkLabel3;
		w13.Add(this.frame3);
		this.scrolledwindow1.Add(w13);
		this.hbox1.Add(this.scrolledwindow1);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.scrolledwindow1]));
		w17.Position = 2;
		this.vpaned1.Add(this.hbox1);
		this.Add(this.vpaned1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}
