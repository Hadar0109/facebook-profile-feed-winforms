using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public static class SavedPostUI
    {
        public static Panel CreatePostPanel(SavedItem i_Item, int i_ContainerWidth)
        {
            int panelWidth = i_ContainerWidth - 60;

            // Using Object Initializers (C# 3.0 feature)
            Panel postPanel = new Panel
            {
                Width = panelWidth,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 15),
                Padding = new Padding(10),
                Name = "savedPanel_" + i_Item.Id,
                BorderStyle = BorderStyle.FixedSingle
            };

            Button unsaveButton = new Button
            {
                Name = "unsaveButton",
                Text = "Remove",
                ForeColor = Color.Red,
                Font = new Font("Segoe UI", 8, FontStyle.Regular),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                AutoSize = true,
                Tag = i_Item
            };

            unsaveButton.FlatAppearance.BorderSize = 0;
            unsaveButton.Location = new Point(postPanel.Width - unsaveButton.PreferredSize.Width - 20, 5);

            FlowLayoutPanel textContainer = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Width = panelWidth - 80,
                Location = new Point(10, 15),
                WrapContents = false
            };

            Label contentLabel = new Label
            {
                Text = i_Item.Content,
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                AutoSize = true,
                MaximumSize = new Size(textContainer.Width - 5, 0),
                Margin = new Padding(0, 0, 0, 10)
            };

            Label categoryLabel = new Label
            {
                Text = $"Category: {i_Item.Category}",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true
            };

            Label dateLabel = new Label
            {
                Text = $"Saved on: {i_Item.SavedAt.ToString("g")}",
                Font = new Font("Segoe UI", 8, FontStyle.Regular),
                ForeColor = Color.DarkGray,
                AutoSize = true
            };

            textContainer.Controls.Add(contentLabel);
            textContainer.Controls.Add(categoryLabel);
            textContainer.Controls.Add(dateLabel);
            postPanel.Controls.Add(unsaveButton);
            postPanel.Controls.Add(textContainer);

            return postPanel;
        }

        public static string SelectCategoryFromDialog()
        {
            using (Form dialog = new Form())
            {
                dialog.Text = "Choose category";
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.Width = 300;
                dialog.Height = 150;
                dialog.StartPosition = FormStartPosition.CenterScreen;

                ComboBox comboBox = new ComboBox
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Location = new Point(20, 20),
                    Width = 240
                };

                comboBox.Items.AddRange(new object[] { "General", "Friends", "Funny", "Work", "Other" });

                comboBox.SelectedIndex = 0;
                Button okButton = new Button
                {
                    Text = "OK",
                    DialogResult = DialogResult.OK,
                    Location = new Point(180, 60)
                };

                dialog.Controls.Add(comboBox);
                dialog.Controls.Add(okButton);
                dialog.AcceptButton = okButton;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return comboBox.SelectedItem.ToString();
                }
            }

            return null;
        }
    }
}
