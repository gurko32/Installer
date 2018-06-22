namespace GtkSharpSamples
{

	using System;
	using System.IO;
	using System.IO.Compression;
	using Gtk;
	using ICSharpCode.SharpZipLib.Zip;
	using ICSharpCode.SharpZipLib.Tar;
	using ICSharpCode.SharpZipLib.GZip;



	public class SampleAssistant : Assistant
	{

		ProgressBar progress_bar;

		public SampleAssistant()
		{
			SetSizeRequest(450, 300);
			Title = "Gtk.Assistant Sample";

			// ANA SAYFA

			Label lbl = new Label("HELLO PEOPLE OF EKINOKS");
			AppendPage(lbl);
			SetPageTitle(lbl, "Introduction");
			SetPageType(lbl, AssistantPageType.Intro);
			SetPageComplete(lbl, true);

			// ZIP SECME SAYFASI


			FileChooserButton fileChooserButton = new FileChooserButton("Choose the instalation zip", 0);
			HBox box = new HBox(true, 1);
			box.PackStart(fileChooserButton);
			fileChooserButton.CurrentFolderChanged += new EventHandler(Deneme);
			AppendPage(box);
			SetPageTitle(box, "Choose zip, people of Ekinoks");
			SetPageType(box, AssistantPageType.Content);


			// MODULE CHOOSER

			HBox moduleBox = new HBox(true, 1);

			Gtk.TreeView tree = new Gtk.TreeView();

			moduleBox.PackStart(tree);

			Gtk.TreeViewColumn moduleColumn = new Gtk.TreeViewColumn();
			moduleColumn.Title = "Module";

			Gtk.TreeViewColumn includeColumn = new Gtk.TreeViewColumn();
			includeColumn.Title = "Include";

			// Add the columns to the TreeView
			tree.AppendColumn(moduleColumn);
			tree.AppendColumn(includeColumn);

			AppendPage(moduleBox);
			SetPageTitle(box, "Choose The Modules");
			SetPageType(box, AssistantPageType.Content);

			//ESKI YAZI SEC SAYFASI
			//HBox box = new HBox(false, 6);
			//box.PackStart(new Label("Enter some text: "), false, false, 6);
			//Entry entry = new Entry();
			//entry.Changed += new EventHandler(EntryChanged);
			//box.PackStart(entry, false, false, 6);
			//Entry entry2 = new Entry();
			//entry2.Changed += new EventHandler(EntryChanged);
			//box.PackStart(entry2, false, false, 6);
			//AppendPage(box);
			//SetPageTitle(box, "Getting Some Input");
			//SetPageType(box, AssistantPageType.Content);

			//CHECKBOXLI EKRAN
			//CheckButton chk = new CheckButton("I think Gtk# is awesome.");
			//chk.Toggled += new EventHandler(ButtonToggled);
			//AppendPage(chk);
			//SetPageTitle(chk, "Provide Feedback");
			//SetPageType(chk, AssistantPageType.Content);

			Alignment al = new Alignment(0.5f, 0.5f, 0.0f, 0.0f);
			box = new HBox(false, 6);
			progress_bar = new ProgressBar();
			box.PackStart(progress_bar, true, true, 6);
			Button btn = new Button("Make progress");
			btn.Clicked += new EventHandler(ButtonClicked);
			box.PackStart(btn, false, false, 6);
			al.Add(box);
			AppendPage(al);
			SetPageTitle(al, "Show Some Progress");
			SetPageType(al, AssistantPageType.Progress);

			lbl = new Label("In addition to being able to type,\nYou obviously have great taste in software.");
			AppendPage(lbl);
			SetPageTitle(lbl, "Congratulations");
			SetPageType(lbl, AssistantPageType.Confirm);
			SetPageComplete(lbl, true);

			Cancel += new EventHandler(AssistantCancel);
			Close += new EventHandler(AssistantClose);
		}

		protected void Deneme(object o, EventArgs args)
		{
			string zipPath = ((FileChooserButton)o).Filename;
			string extractPath = ((FileChooserButton)o).Filename;
			//((FileChooserButton)o).CurrentFolderUri.Substring(7);

			try
			{
				if (zipPath.EndsWith(".zip"))
				{
					FastZip fastZip = new FastZip();
					fastZip.ExtractZip(zipPath, extractPath.Replace(".zip", ""), null);

					SetPageComplete(GetNthPage(CurrentPage), true);

				}
				else if (zipPath.EndsWith(".tar.gz"))
				{
					Stream inStream = File.OpenRead(zipPath);
					Stream gzipStream = new GZipInputStream(inStream);

					TarArchive tarArchive = TarArchive.CreateInputTarArchive(gzipStream);
					tarArchive.ExtractContents(extractPath.Replace(".tar.gz", ""));
					tarArchive.Close();

					inStream.Close();

					SetPageComplete(GetNthPage(CurrentPage), true);

				}
				else
				{
					Console.WriteLine("Unsupported File Type");
					SetPageComplete(GetNthPage(CurrentPage), false);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("HATA VAR " + ex);
			}
		}

		protected override bool OnDeleteEvent(Gdk.Event ev)
		{
			Console.WriteLine("Assistant Destroyed prematurely");
			Application.Quit();
			return true;
		}

		// If there is text in the GtkEntry, set the page as complete.
		void EntryChanged(object o, EventArgs args)
		{
			string text = (o as Gtk.Entry).Text;
			SetPageComplete(GetNthPage(CurrentPage), text.Length > 0);
		}

		// If check button is checked, set the page as complete.
		void ButtonToggled(object o, EventArgs args)
		{
			bool active = (o as ToggleButton).Active;
			SetPageComplete(o as Widget, active);
		}

		// Progress 10% per second after button clicked.
		void ButtonClicked(object o, EventArgs args)
		{
			(o as Widget).Sensitive = false;
			GLib.Timeout.Add(500, new GLib.TimeoutHandler(TimeoutCallback));
		}

		double fraction = 0.0;

		bool TimeoutCallback()
		{
			fraction += 5.0;
			progress_bar.Fraction = fraction / 100.0;
			progress_bar.Text = String.Format("{0}% Complete", fraction);
			if (fraction == 100.0)
			{
				SetPageComplete(progress_bar.Parent.Parent, true);
				return false;
			}
			return true;
		}

		void AssistantCancel(object o, EventArgs args)
		{
			Console.WriteLine("Assistant cancelled.");
			Destroy();
			Application.Quit();
		}

		void AssistantClose(object o, EventArgs args)
		{
			Console.WriteLine("Assistant ran to completion.");
			Destroy();
			Application.Quit();
		}

		public static int Main(string[] argv)
		{
			Application.Init();
			new SampleAssistant().ShowAll();
			Application.Run();
			return 0;
		}
	}
}
