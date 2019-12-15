using LastCheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BiBuddy.UI
{
    /// <summary>
    /// Interaction logic for AddPanels.xaml
    /// </summary>
    public partial class AddPanels : Window
    {
        SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.databasePath);
        public AddPanels()
        {
            InitializeComponent();
        }

        private void addClickP(object sender, RoutedEventArgs e)
        {
            conn.CreateTable<Academic>();
            
            if (sPanelArticleTxB.Visibility == Visibility.Visible)
            {
                Academic academic = new Academic()
                {
                    EntryType = "Article",
                    Author = ArticleAuthor.Text,
                    Title = ArticleAuthor.Text,
                    Journal = ArticleJournal.Text,
                    Year = ArticleYear.Text,
                    Volume = ArticleVolume.Text,
                    Number = ArticleNumber.Text,
                    Pages = ArticlePages.Text,
                    Month = ArticleMonth.Text,
                    Doi = ArticleDoi.Text,
                    Note = ArticleNote.Text,
                    Key = ArticleKey.Text
                };
                conn.Insert(academic);
            }
            if (sPanelConferenceTxB.Visibility == Visibility.Visible)
            {
                Academic academic = new Academic()
                {
                    EntryType = "Conference",
                    Author = ConferenceAuthor.Text,
                    Title = ConferenceTitle.Text,
                    Booktitle = ConferenceBookTitle.Text,
                    Year = ConferenceYear.Text,
                    Editor = ConferenceEditor.Text,
                    Series = ConferenceSeries.Text,
                    Pages = ConferencePages.Text,
                    Address = ConferenceAddress.Text,
                    Month = ConferenceMonth.Text,
                    Organization = ConferenceOrganizaton.Text,
                    Publisher = ConferencePublisher.Text,
                    Note = ConferenceNote.Text,
                    Key = ConferenceKey.Text
                };
                conn.Insert(academic);
            }




            this.Close(); // This command should be the latest command end of the line! -Asil
        }// when the panels finish i need to collapse all of the panels. - Asil // Please use if conditions cause when the something is already collapsed and u'll try to collapse it again maybe it creates crush for this app.
    }
}
