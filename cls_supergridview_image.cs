using DevComponents.DotNetBar.SuperGrid;
using System.Windows.Forms;

namespace gym_management_system
{
    class cls_supergridview_image
    {
        
        #region Initialize Gridview img

        public void InitializeGrid(SuperGridControl grid,string col_name,ImageSizeMode mode, ImageList imglst)
        {
            GridPanel panel = grid.PrimaryGrid;

            // Set the ImageEdit column EditorType to our EditControl type
            // so that we can send it the ImageList and SizeMode to use

            GridColumn column = panel.Columns[col_name];
            column.EditorType = typeof(MyGridImageEditControl);
            column.EditorParams = new object[] { imglst, mode };




        }

        #endregion

        #region Class MyGridImageEditControl

        private class MyGridImageEditControl : GridImageEditControl
        {
            public MyGridImageEditControl(
                ImageList imageList, ImageSizeMode sizeMode)
            {
                ImageList = imageList;
                ImageSizeMode = sizeMode;
            }
        }
        #endregion

        #region SetNewSizeMode

        private void SetNewSizeMode(
            GridImageEditControl ic, ImageSizeMode sizeMode)
        {
            if (ic != null)
                ic.ImageSizeMode = sizeMode;
        }
        #endregion
    }
}
