
// This file has been generated by the GUI designer. Do not modify.

public partial class USB
{
	private global::Gtk.VPaned vpaned1;

	private global::Gtk.Label label;

	private global::Gtk.EventBox eventbox1;

	private global::Gtk.Fixed fixed1;

	private global::Gtk.Button button2;

	private global::Gtk.Button button1;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget USB
		this.Name = "USB";
		this.Title = global::Mono.Unix.Catalog.GetString("USB READ");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child USB.Gtk.Container+ContainerChild
		this.vpaned1 = new global::Gtk.VPaned();
		this.vpaned1.CanFocus = true;
		this.vpaned1.Name = "vpaned1";
		this.vpaned1.Position = 148;
		// Container child vpaned1.Gtk.Paned+PanedChild
		this.label = new global::Gtk.Label();
		this.label.Name = "label";
		this.vpaned1.Add(this.label);
		global::Gtk.Paned.PanedChild w1 = ((global::Gtk.Paned.PanedChild)(this.vpaned1[this.label]));
		w1.Resize = false;
		// Container child vpaned1.Gtk.Paned+PanedChild
		this.eventbox1 = new global::Gtk.EventBox();
		this.eventbox1.Name = "eventbox1";
		this.eventbox1.VisibleWindow = false;
		// Container child eventbox1.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button2 = new global::Gtk.Button();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("   Stop  ");
		this.fixed1.Add(this.button2);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button2]));
		w2.X = 266;
		w2.Y = 14;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("   Pusk   ");
		this.fixed1.Add(this.button1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
		w3.X = 178;
		w3.Y = 14;
		this.eventbox1.Add(this.fixed1);
		this.vpaned1.Add(this.eventbox1);
		this.Add(this.vpaned1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 341;
		this.DefaultHeight = 217;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button2.Clicked += new global::System.EventHandler(this.On_bStop);
		this.button1.Clicked += new global::System.EventHandler(this.On_bPusk);
	}
}
