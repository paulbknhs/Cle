using System.Configuration;
using CregForm.AddSpecific;
using CregForm.Resources.classes;
using Microsoft.Identity.Client;
using RJCodeAdvance.RJControls;

namespace CregForm.Views;

public partial class AddView : UserControl
{
    public AddView()
    {
        InitializeComponent();
    }

    #region ContentFrame Navigation

    private void SelectNavigation(object selection)
    {
        var selectedButton = (Button)selection;
        foreach (Control control in TabNavControl.Controls)
        {
            if (control is not Button b || b.Tag == null) continue;
            b.Tag = null;
            b.Invalidate();
        }

        selectedButton.Tag = "selected";
        selectedButton.Invalidate();
    }

    private void OnTabNavPaint(object sender, PaintEventArgs e)
    {
        var btn = (Button)sender;
        if (ReferenceEquals(btn.Tag, "selected"))
        {
            e.Graphics.FillRectangle(Brushes.Green, new Rectangle(0, 0, btn.Width, 2));
            btn.Font = new Font(btn.Font, FontStyle.Bold);
        }
        else
        {
            btn.Font = new Font(btn.Font, FontStyle.Regular);
        }
    }

    private void ClearUserControl()
    {
        if (ContentFrame == null) return;
        foreach (var frameControl in from Control frameControl in ContentFrame.Controls
                                     where frameControl is UserControl
                                     select frameControl)
        {
            ContentFrame.Controls.Remove(frameControl);
        }
    }

    #endregion

    #region ContentFrame Switch

    private void ButtonSgb8_Click(object sender, EventArgs e)
    {
        SelectNavigation(sender);

        ClearUserControl();
        var sgb8 = new Sgb8();
        ContentFrame.Controls.Add(sgb8);
    }

    private void ButtonMutterKind_Click(object sender, EventArgs e)
    {
        SelectNavigation(sender);

        ClearUserControl();
        var muKi = new MutterKind();
        ContentFrame.Controls.Add(muKi);
    }

    private void ButtonP56_Click(object sender, EventArgs e)
    {
        SelectNavigation(sender);

        ClearUserControl();
        var p56 = new P218();
        ContentFrame.Controls.Add(p56);
    }

    private void ButtonAllgSgs_Click(object sender, EventArgs e)
    {
        SelectNavigation(sender);

        ClearUserControl();
        var allgSgs = new AllgSgs();
        ContentFrame.Controls.Add(allgSgs);
    }

    private void ButtonArge_Click(object sender, EventArgs e)
    {
        SelectNavigation(sender);

        ClearUserControl();
        var arge = new ARGE();
        ContentFrame.Controls.Add(arge);
    }

    private void ButtonP2a_Click(object sender, EventArgs e)
    {
        SelectNavigation(sender);

        ClearUserControl();
        var p2A = new P2a();
        ContentFrame.Controls.Add(p2A);
    }

    private void ButtonEheUndLeben_Click(object sender, EventArgs e)
    {
        SelectNavigation(sender);

        ClearUserControl();
        var eheUndLeben = new EheUndLeben();
        ContentFrame.Controls.Add(eheUndLeben);
    }

    #endregion

    #region OnLoad

    private void SetDropDowns()
    {
        dropARGE.DataSource = LSTS.Arge;
        dropMigra.DataSource = LSTS.Migra;
        dropAnregung.DataSource = LSTS.Anregung;
        dropAnmeldung.DataSource = LSTS.Anmeldung;
        dropBeratung.DataSource = LSTS.Beratung;
        dropGrund.DataSource = LSTS.Grund;
    }

    private void InitializeContent()
    {
        ButtonEheUndLeben.Tag = "selected";
        ClearUserControl();
        var eheUndLeben = new EheUndLeben();
        ContentFrame.Controls.Add(eheUndLeben);
    }

    #endregion

    #region DGridV Alter

    private void SetGridAlter()
    {
        foreach (var person in LSTS.Personen)
            gridAlter.Rows.Add(person);

        gridAlter.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        gridAlter.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    }

    private void OnValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        var grid = (DataGridView)sender;
        if (e.RowIndex < 0 || e.RowIndex >= grid.Rows.Count) return;
        var row = grid.Rows[e.RowIndex];
        if (e.ColumnIndex < 0 || e.ColumnIndex >= row.Cells.Count) return;
        var cell = row.Cells[e.ColumnIndex];

        if (cell.Value == null) return;

        foreach (DataGridViewCell c in row.Cells)
        {
            if (c.ColumnIndex == e.ColumnIndex || c.ColumnIndex == 0) continue;
            c.Value = null;
        }
    }

    #endregion
    

    private void OnLoad(object sender, EventArgs e)
    {
        SetDropDowns();
        InitializeContent();
        SetGridAlter();
    }

    private void OnToggle(object sender, EventArgs e)
    {
        var toggle = (RJToggleButton)sender;

        if (toggle.Checked)
        {
            dropGrund.Enabled = true;
            dropGrund.SelectedIndex = 0;
            dropGrund.BorderColor = Color.Black;
            dropGrund.IconColor = Color.Black;
        }
        else
        {
            dropGrund.Enabled = false;
            dropGrund.SelectedIndex = 0;
            dropGrund.BorderColor = Color.Gray;
            dropGrund.IconColor = Color.Gray;
        }
    }

    private void OnButtonSave(object sender, EventArgs e)
    {
        var confirmResult = MessageBox.Show("Eintrag speichern?", "Speichern", MessageBoxButtons.YesNo);
        if (confirmResult != DialogResult.Yes) return;


        DICT.Allgemein.Clear();
        DSTR.StoreTextBoxContent(this, DICT.Allgemein);
        DSTR.StoreDropDownContent(this, DICT.Allgemein);
        DSTR.StoreToggleContent(this, DICT.Allgemein);
        DSTR.StoreAlterGridContent(this, DICT.Allgemein);
        


        DatabaseHelper database = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
        database.Connect();
        database.InsertData("Allgemein", DICT.Allgemein);
        database.Disconnect();

    }
}