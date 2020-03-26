# How to change the text color of the editor in Xamarin.Forms DataForm (SfDataForm)

You can change the default text color of the Text and MultilineText editor in Xamarin.Forms [SfDataForm](https://help.syncfusion.com/xamarin/dataform/getting-started?) by using custom editor.

You can create and add custom editor to SfDataForm by overriding the [DataFormEditor](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfDataForm.XForms~Syncfusion.XForms.DataForm.Editors.DataFormEditor%601.html?) class, where the CustomMultilineTextEditor and CustomTextEditor is inherited using the [DataFormMultilineTextEditor](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfDataForm.XForms~Syncfusion.XForms.DataForm.Editors.DataFormMultiLineTextEditor.html?) and [DataFormTextEditor](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfDataForm.XForms~Syncfusion.XForms.DataForm.Editors.DataFormTextEditor.html?).

Refer to the [online user guide documentation](https://help.syncfusion.com/xamarin/sfdataform/editors?) for creating new custom editor in DataForm.

**C#**

Text editor color changed by customizing DataFormTextEditor.
``` c#
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
```
**C#**

MultilineText editor color changed by customizing DataFormMultiLineTextEditor.
``` c#
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
```
Refer to the following code example for binding [DataObject](https://help.syncfusion.com/xamarin-android/sfdataform/getting-started?) and register the editor using [RegisterEditor](https://help.syncfusion.com/cr/cref_files/xamarin-android/Syncfusion.SfDataForm.Android~Syncfusion.Android.DataForm.SfDataForm~RegisterEditor.html?) as CustomTextEditor and CustomMultilineTextEditor to make data form items as custom editor in DataForm.

**C#**

Customized Text and MultilineText editors registered to DataForm.
``` c#
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
}
```
