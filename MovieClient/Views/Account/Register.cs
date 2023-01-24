@{
  Layout = "_Layout";
}

@using MovieClient.ViewModels

@model RegisterViewModel

<h2>Register a new user</h2>
<hr />

@if(!ViewData.ModelState.IsValid) 
{
  @Html.ValidationSummary("Please fix the following error(s) and then resubmit the form:") 
}

<!-- api contact method needed? -->
@using (Html.BeginForm("Register", "Account", FormMethod.Post))
{
  @Html.LabelFor(user => user.Email)
  @Html.TextBoxFor(user=> user.Email)
  
  @*
  @Html.LabelFor(user=> user.Name)
  @Html.EditorFor(user=> user.Name)
  *@

  @Html.LabelFor(user=> user.Password)
  @Html.EditorFor(user=> user.Password)

  @Html.LabelFor(user=> user.ConfirmPassword)
  @Html.EditorFor(user=> user.ConfirmPassword)

  //image uploader?

  <input type="submit" value="Register" />
}

<p>@Html.ActionLink("Back to accounts page", "Index")</p>