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
                if (ArticleAuthor.Text == "" || ArticleTitle.Text == "" || ArticleJournal.Text == "" || ArticleYear.Text == "" || ArticleVolume.Text == "")
                {
                    MessageBox.Show("You need to fill all required fields! ", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else { 
                    conn.Insert(academic);
                }
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
                if (ConferenceAuthor.Text == "" || ConferenceTitle.Text == "" || ConferenceBookTitle.Text == "" || ConferenceYear.Text == "")
                {
                    MessageBox.Show("You need to fill all required fields! ", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else
                {
                    conn.Insert(academic);
                }
            }
            if (sPanelBookletTxB.Visibility == Visibility.Visible)
            {
                Academic academic = new Academic()
                {
                    EntryType = "Booklet",
                    Title = BookletTitle.Text,
                    Author = BookletAuthor.Text,
                    Howpublished = BookletHowpublished.Text,
                    Address = BookletAddress.Text,
                    Month = BookletMonth.Text,
                    Year = BookletYear.Text,
                    Note = BookletNote.Text,
                    Key = BookletKey.Text
                };
                if (BookletTitle.Text == "")
                {
                    MessageBox.Show("You need to fill all required fields! ", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else
                {
                    conn.Insert(academic);
                }
            }
            if (sPanelBookTxB.Visibility == Visibility.Visible)
            {
                Academic academic = new Academic()
                {
                    EntryType = "Book",
                    Author = BookAuthor.Text,
                    Title = BookTitle.Text,
                    Publisher = BookPublisher.Text,
                    Year = BookYear.Text,
                    Volume = BookVolume.Text,
                    Series = BookSeries.Text,
                    Address = BookAddress.Text,
                    Edition  = BookEdition.Text,
                    Month = BookMonth.Text,
                    Note = BookNote.Text,
                    Key = BookKey.Text,
                    Url = BookUrl.Text,
                };
                if (BookAuthor.Text == "" || BookTitle.Text == "" || BookPublisher.Text == "" || BookYear.Text == "")
                {
                    MessageBox.Show("You need to fill all required fields! ", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else
                {
                    conn.Insert(academic);
                }
            }
            if (sPanelInbookTxB.Visibility == Visibility.Visible)
            {
                Academic academic = new Academic()
                {
                    EntryType = "Inbook",
                    Author = InbookAuthor.Text,
                    Title = InbookTitle.Text,
                    Chapter = InbookChapter.Text,
                    Publisher = InbookPublisher.Text,
                    Year = InbookYear.Text,
                    Volume = InbookYear.Text,
                    Series = InbookSeries.Text,
                    Type = InbookType.Text,
                    Address = InbookAddress.Text,
                    Edition = InbookEdition.Text,
                    Month = InbookMonth.Text,
                    Note = InbookNote.Text,
                    Key = InbookKey.Text,
                };
                if (InbookAuthor.Text == "" || InbookTitle.Text == "" || InbookChapter.Text == "" || InbookPublisher.Text == "" || InbookYear.Text == "")
                {
                    MessageBox.Show("You need to fill all required fields! ", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else
                {
                    conn.Insert(academic);
                }
            }
            if (sPanelIncollectionTxB.Visibility == Visibility.Visible)
            {
                Academic academic = new Academic()
                {
                    EntryType = "Incollection",
                    Author = IncollectionAuthor.Text,
                    Title = IncollectionTitle.Text,
                    Booktitle = IncollectionBooktitle.Text,
                    Publisher = IncollectionPublisher.Text,
                    Year = IncollectionYear.Text,
                    Editor = IncollectionEditor.Text,
                    Volume = IncollectilonVolume.Text,
                    Series = IncollectionSeries.Text,
                    Type = IncollectionType.Text,
                    Chapter = IncollectionChapter.Text,
                    Pages = IncollectionPages.Text,
                    Address = IncollectionAddress.Text,
                    Edition = IncollectionEdition.Text,
                    Month= InbookMonth.Text,
                    Note = IncollectionNote.Text,
                    Key = IncollectionKey.Text,
                };
                if (IncollectionAuthor.Text == "" || IncollectionTitle.Text == "" || IncollectionBooktitle.Text == "" || IncollectionPublisher.Text == "" || IncollectionYear.Text == "")
                {
                    MessageBox.Show("You need to fill all required fields! ", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else
                {
                    conn.Insert(academic);
                }
            }
            if (sPanelManualTxB.Visibility == Visibility.Visible)
            {
                Academic academic = new Academic()
                {
                    EntryType = "Manual",
                    Title = ManualTitle.Text,
                    Author = ManualAuthor.Text,
                    Organization = ManualOrganization.Text,
                    Address = ManualYear.Text,
                    Edition = ManualEdition.Text,
                    Month = ManualMonth.Text,
                    Year = ManualYear.Text,
                    Note = ManualNote.Text,
                    Key = ManualKey.Text,
                };
                if (ManualTitle.Text == "")
                {
                    MessageBox.Show("You need to fill all required fields! ", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else
                {
                    conn.Insert(academic);
                }
            }


            this.Close(); // This command should be the latest command end of the line! -Asil
        }// when the panels finish i need to collapse all of the panels. - Asil // Please use if conditions cause when the something is already collapsed and u'll try to collapse it again maybe it creates crush for this app.
    }
}
