using Nancy;
using TriangleTracker.Objects;
using System;

namespace TriangleTracker
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/form"] = _ => {
                return View["form.cshtml"];
            };
            Get["/triangleTrackerDisplay"] =_=> {
                string side1 = Request.Query["side1"];
                string side2 = Request.Query["side2"];
                string side3 = Request.Query["side3"];
                string[] formValues = { side1, side2, side3 };

                if(Array.Exists(formValues, element => element == "")) {
                    return View["form.cshtml"];
                }
                else
                {
                    Triangle newTriangle = new Triangle(int.Parse(side1), int.Parse(side2), int.Parse(side3));

                    return View["triangle-display.cshtml", newTriangle];
                }
            };
        }
    }
}
