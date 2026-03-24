using System.Xml.Linq;

namespace Library_Borrowing_Verification_System
{
    public partial class Form1 : Form
    {
        public static List<BorrowRecord> records = new List<BorrowRecord>();
        public Form1()
        {
            InitializeComponent();
        }

        private void picBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtBook.Text))
                    throw new Exception("Fill all fields.");

                records.Add(new BorrowRecord
                {
                    Name = txtName.Text,
                    Book = txtBook.Text,
                    BorrowDate = DateTime.Now,
                    ReturnDate = null
                });

                if (!listNames.Items.Contains(txtName.Text))
                {
                    listNames.Items.Add(txtName.Text);
                }



                MessageBox.Show("Book borrowed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Console.WriteLine("Borrow done.");
            }
        }

        private void picReturn_Click(object sender, EventArgs e)
        {
            try
            {
                var record = records.FirstOrDefault(r =>
                    r.Name == txtName.Text &&
                    r.Book == txtBook.Text &&
                    r.ReturnDate == null);

                if (record != null)
                {
                    record.ReturnDate = DateTime.Now;

                    bool hasActive = records.Any(r =>
                    r.Name == txtName.Text && r.ReturnDate == null);

                    if (!hasActive)
                    {
                        listNames.Items.Remove(txtName.Text);
                    }



                    MessageBox.Show("Book returned!");
                }
                else
                {
                    MessageBox.Show("No active record.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Console.WriteLine("Return done.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            txtName.Clear();
            txtBook.Clear();
        }

        private void listNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = listNames.SelectedItem.ToString();

            var userRecords = records
                .Where(r => r.Name == selectedName)
                .ToList();

            string result = "";

            foreach (var r in userRecords)
            {
                result += $"Book: {r.Book}\n" +
                 $"Borrowed: {r.BorrowDate}\n" +
      
                 $"Status: {(r.ReturnDate == null ? "Not Returned" : "Returned")}\n\n";
            }

            lblResult.Text = result;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




