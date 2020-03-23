using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataFormXamarin
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        SfDataForm dataForm;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            dataForm = bindable.FindByName<SfDataForm>("dataForm");
            dataForm.RegisterEditor("MultilineText", new CustomMultilineTextEditor(dataForm));
            dataForm.RegisterEditor("Text", new CustomTextEditor(dataForm));
        } 
    }

    public class CustomMultilineTextEditor : DataFormMultiLineTextEditor
    {
        public CustomMultilineTextEditor( SfDataForm dataForm) :base(dataForm)
        {
        }


        protected override void OnInitializeView(DataFormItem dataFormItem, Editor view)
        {
            base.OnInitializeView(dataFormItem, view);
            dataFormItem.UnfocusedColor = Color.Red;
            dataFormItem.FocusedColor = Color.Blue;
            view.TextColor = Color.DarkOrange;
        }
    }
    public class CustomTextEditor : DataFormTextEditor
    {
        public CustomTextEditor(SfDataForm dataForm) : base(dataForm)
        {
        }

        protected override void OnInitializeView(DataFormItem dataFormItem, Entry view)
        {
            base.OnInitializeView(dataFormItem, view);
            dataFormItem.UnfocusedColor = Color.Brown;
            dataFormItem.FocusedColor = Color.DarkGreen;
            view.TextColor = Color.DarkViolet;
        }
    }
}
