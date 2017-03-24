using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk;
using MsCrmTools.SiteMapEditor.AppCode;

namespace MsCrmTools.SiteMapEditor.Forms
{
    public partial class SiteMapPicker : Form
    {
        public SiteMapPicker(EntityCollection ec)
        {
            InitializeComponent();

            foreach (var entity in ec.Entities)
            {
                var item = new ListViewItem(entity.GetAttributeValue<string>("name"))
                {
                    Tag = entity
                };
                entity.Attributes.Remove("name");
                lvSitemaps.Items.Add(item);
            }
        }

        public Entity SelectedSitemap { get; private set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lvSitemaps.SelectedItems.Count == 0)
            {
                return;
            }

            SelectedSitemap = (Entity)lvSitemaps.SelectedItems[0].Tag;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lvSitemaps_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var listview = (ListView) sender;
            listview.Sorting = listview.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            listview.ListViewItemSorter = new ListViewItemComparer(e.Column, listview.Sorting);
        }

        private void lvSitemaps_DoubleClick(object sender, EventArgs e)
        {
            btnOK_Click(this, e);
        }
    }
}
