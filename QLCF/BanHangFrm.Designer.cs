namespace QLCF
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new DevExpress.XtraEditors.SplitContainerControl();
            this.flowLayout1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbCurrentTable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPay = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.btnDeleteItem = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridCtrlProduct = new DevExpress.XtraGrid.GridControl();
            this.gridVProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCtrlCategory = new DevExpress.XtraGrid.GridControl();
            this.gridVCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscountPrice = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubTotal = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCtrlTable = new DevExpress.XtraGrid.GridControl();
            this.gridVTable = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVTable)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.flowLayout1);
            this.splitContainer.Panel1.Text = "Panel1";
            this.splitContainer.Panel2.Controls.Add(this.lbCurrentTable);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.label5);
            this.splitContainer.Panel2.Controls.Add(this.btnPay);
            this.splitContainer.Panel2.Controls.Add(this.txtSoLuong);
            this.splitContainer.Panel2.Controls.Add(this.btnDeleteItem);
            this.splitContainer.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer.Panel2.Controls.Add(this.gridCtrlProduct);
            this.splitContainer.Panel2.Controls.Add(this.gridCtrlCategory);
            this.splitContainer.Panel2.Controls.Add(this.txtTotal);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.txtDiscountPrice);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.txtSubTotal);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.gridCtrlTable);
            this.splitContainer.Panel2.Text = "Panel2";
            this.splitContainer.Size = new System.Drawing.Size(1458, 795);
            this.splitContainer.SplitterPosition = 519;
            this.splitContainer.TabIndex = 0;
            this.splitContainer.Text = "splitContainer";
            // 
            // flowLayout1
            // 
            this.flowLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout1.Location = new System.Drawing.Point(0, 0);
            this.flowLayout1.Name = "flowLayout1";
            this.flowLayout1.Size = new System.Drawing.Size(519, 795);
            this.flowLayout1.TabIndex = 0;
            // 
            // lbCurrentTable
            // 
            this.lbCurrentTable.AutoSize = true;
            this.lbCurrentTable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbCurrentTable.Location = new System.Drawing.Point(152, 66);
            this.lbCurrentTable.Name = "lbCurrentTable";
            this.lbCurrentTable.Size = new System.Drawing.Size(16, 23);
            this.lbCurrentTable.TabIndex = 17;
            this.lbCurrentTable.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bàn đang chọn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 637);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "VNĐ";
            // 
            // btnPay
            // 
            this.btnPay.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Appearance.Options.UseFont = true;
            this.btnPay.Location = new System.Drawing.Point(447, 664);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(116, 119);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.EditValue = "1";
            this.txtSoLuong.Location = new System.Drawing.Point(447, 190);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSoLuong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSoLuong.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtSoLuong.Size = new System.Drawing.Size(100, 30);
            this.txtSoLuong.TabIndex = 12;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Appearance.Options.UseFont = true;
            this.btnDeleteItem.Location = new System.Drawing.Point(447, 314);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(100, 52);
            this.btnDeleteItem.TabIndex = 11;
            this.btnDeleteItem.Text = "Xóa >>";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(447, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 52);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "<< Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridCtrlProduct
            // 
            this.gridCtrlProduct.Location = new System.Drawing.Point(597, 314);
            this.gridCtrlProduct.MainView = this.gridVProduct;
            this.gridCtrlProduct.Name = "gridCtrlProduct";
            this.gridCtrlProduct.Size = new System.Drawing.Size(325, 478);
            this.gridCtrlProduct.TabIndex = 9;
            this.gridCtrlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVProduct});
            // 
            // gridVProduct
            // 
            this.gridVProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridVProduct.GridControl = this.gridCtrlProduct;
            this.gridVProduct.Name = "gridVProduct";
            this.gridVProduct.OptionsView.ShowGroupPanel = false;
            this.gridVProduct.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridVProduct_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Name";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridCtrlCategory
            // 
            this.gridCtrlCategory.Location = new System.Drawing.Point(597, 25);
            this.gridCtrlCategory.MainView = this.gridVCategory;
            this.gridCtrlCategory.Name = "gridCtrlCategory";
            this.gridCtrlCategory.Size = new System.Drawing.Size(325, 264);
            this.gridCtrlCategory.TabIndex = 8;
            this.gridCtrlCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVCategory});
            this.gridCtrlCategory.Click += new System.EventHandler(this.gridCtrlCategory_Click);
            // 
            // gridVCategory
            // 
            this.gridVCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CatName});
            this.gridVCategory.GridControl = this.gridCtrlCategory;
            this.gridVCategory.Name = "gridVCategory";
            this.gridVCategory.OptionsView.ShowGroupPanel = false;
            this.gridVCategory.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridVCategory_CustomDrawRowIndicator);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "Id";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.Width = 43;
            // 
            // CatName
            // 
            this.CatName.Caption = "Name";
            this.CatName.FieldName = "Name";
            this.CatName.Name = "CatName";
            this.CatName.OptionsColumn.AllowEdit = false;
            this.CatName.Visible = true;
            this.CatName.VisibleIndex = 0;
            this.CatName.Width = 264;
            // 
            // txtTotal
            // 
            this.txtTotal.EditValue = "0";
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(166, 737);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(249, 30);
            this.txtTotal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 740);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng cộng:";
            // 
            // txtDiscountPrice
            // 
            this.txtDiscountPrice.EditValue = "0";
            this.txtDiscountPrice.Location = new System.Drawing.Point(257, 634);
            this.txtDiscountPrice.Name = "txtDiscountPrice";
            this.txtDiscountPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPrice.Properties.Appearance.Options.UseFont = true;
            this.txtDiscountPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscountPrice.Size = new System.Drawing.Size(112, 30);
            this.txtDiscountPrice.TabIndex = 4;
            this.txtDiscountPrice.TextChanged += new System.EventHandler(this.txtDiscountPrice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 637);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giảm giá:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.EditValue = "0";
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(166, 584);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Properties.Appearance.Options.UseFont = true;
            this.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotal.Size = new System.Drawing.Size(249, 30);
            this.txtSubTotal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền:";
            // 
            // gridCtrlTable
            // 
            this.gridCtrlTable.Location = new System.Drawing.Point(1, 109);
            this.gridCtrlTable.MainView = this.gridVTable;
            this.gridCtrlTable.Name = "gridCtrlTable";
            this.gridCtrlTable.Size = new System.Drawing.Size(414, 432);
            this.gridCtrlTable.TabIndex = 0;
            this.gridCtrlTable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVTable});
            // 
            // gridVTable
            // 
            this.gridVTable.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OrderID,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridVTable.GridControl = this.gridCtrlTable;
            this.gridVTable.Name = "gridVTable";
            this.gridVTable.OptionsView.ShowGroupPanel = false;
            this.gridVTable.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridVTable_CustomDrawRowIndicator);
            // 
            // OrderID
            // 
            this.OrderID.Caption = "ID";
            this.OrderID.FieldName = "Id";
            this.OrderID.Name = "OrderID";
            this.OrderID.Visible = true;
            this.OrderID.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Name";
            this.gridColumn3.FieldName = "Product.Name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cost";
            this.gridColumn4.FieldName = "Cost";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Count";
            this.gridColumn5.FieldName = "Count";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Total";
            this.gridColumn6.FieldName = "Total";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 795);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainFrm";
            this.Text = "Bán Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayout1;
        private DevExpress.XtraGrid.GridControl gridCtrlTable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVTable;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtDiscountPrice;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtSubTotal;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridCtrlProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVProduct;
        private DevExpress.XtraGrid.GridControl gridCtrlCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVCategory;
        private DevExpress.XtraEditors.SimpleButton btnPay;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.SimpleButton btnDeleteItem;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CatName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn OrderID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCurrentTable;
        private System.Windows.Forms.Label label4;
    }
}