[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create(Insuree insuree)
{
    if (ModelState.IsValid)
    {
        // Base quote
        decimal quote = 50m;

        // Calculate age
        var today = DateTime.Today;
        var age = today.Year - insuree.DateOfBirth.Year;
        if (insuree.DateOfBirth > today.AddYears(-age)) age--;

        // Age-based price addition
        if (age <= 18)
            quote += 100;
        else if (age >= 19 && age <= 25)
            quote += 50;
        else
            quote += 25;

        // Car year
        if (insuree.CarYear < 2000)
            quote += 25;
        if (insuree.CarYear > 2015)
            quote += 25;

        // Car make and model
        if (insuree.CarMake.ToLower() == "porsche")
        {
            quote += 25;
            if (insuree.CarModel.ToLower() == "911 carrera")
                quote += 25;
        }

        // Speeding tickets
        quote += insuree.SpeedingTickets * 10;

        // DUI
        if (insuree.DUI)
            quote *= 1.25m;

        // Coverage type
        if (insuree.CoverageType)
            quote *= 1.5m;

        // Final quote
        insuree.Quote = quote;

        db.Insurees.Add(insuree);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    return View(insuree);
}
< !--Remove or comment this out -->
<!--
<div class= "form-group" >
    @Html.LabelFor(model => model.Quote, htmlAttributes: new { @class = "control-label col-md-2" })
    < div class= "col-md-10" >
        @Html.EditorFor(model => model.Quote, new { htmlAttributes = new { @class = "form-control" } })
        @Html.ValidationMessageFor(model => model.Quote, "", new { @class = "text-danger" })
    </ div >
</ div >
-->
public ActionResult Admin()
{
    var insurees = db.Insurees.ToList();
    return View(insurees);
}
@model IEnumerable<YourNamespace.Models.Insuree>

@{
    ViewBag.Title = "Admin";
}

< h2 > Admin - All Quotes </ h2 >

< table class= "table" >
    < tr >
        < th > First Name </ th >
        < th > Last Name </ th >
        < th > Email Address </ th >
        < th > Quote </ th >
    </ tr >

@foreach(var item in Model) {
    < tr >
        < td > @item.FirstName </ td >
        < td > @item.LastName </ td >
        < td > @item.EmailAddress </ td >
        < td > @item.Quote.ToString("C") </ td >
    </ tr >
}
</ table >
