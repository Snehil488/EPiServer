@using EPiServer.Editor
@using EPiServer.Security
@model SearchContentModel

@{
    Layout = "~/Views/Shared/Layouts/_TwoPlusOne.cshtml";
}

<div class="row">
    <div class="span8,search-form">
        @*We use GET to submit the form to enable bookmarking etc of search results.  However, as GET will remove other
        query string values not in the form we can't use that in edit mode.*@

        @{
            using (Html.BeginForm(null, null, PageEditing.PageIsInEditMode ? FormMethod.Post : FormMethod.Get, new { @action = Model.Layout.SearchActionUrl }))
            {
                <input type="text" tabindex="1" name="q" value="@Model.SearchedQuery" />
                <input type="submit" tabindex="2" class="btn" value="@Html.Translate("/searchpagetemplate/searchbutton")" disabled="@(Model.SearchServiceDisabled ? "disabled" : null)" />
            }
        }
    </div>
</div>

@if(Model.Hits != null)
{
    <div class="row">
        <div class="span8 grayHead">
            <h2>@Html.Translate("/searchpagetemplate/result")</h2>
            <p>
                @Html.Translate("/searchpagetemplate/searchfor") <i>@Model.SearchedQuery</i>
                @Html.Translate("/searchpagetemplate/resultedin")
                @if(Model.NumberOfHits > 0)
                {
                    @Model.NumberOfHits
                }
                else
                {
                    @Html.Translate("/searchpagetemplate/zero")
                }
                @Html.Translate("/searchpagetemplate/hits")
            </p>
        </div>
    </div>

    <div class="row">
        <div class="span8 SearchResults">
            @foreach (var hit in Model.Hits)
            {
                <div class="listResult">
                    <h3><a href="@hit.Url">@hit.Title</a></h3>
                    <p>@hit.Excerpt</p>
                    <hr />
                </div>
            }
        </div>
    </div>

}

@if(Model.SearchServiceDisabled && PrincipalInfo.HasEditAccess)
{
    @Html.Partial("TemplateHint", Html.Translate("/searchpagetemplate/disabled" ))
}
