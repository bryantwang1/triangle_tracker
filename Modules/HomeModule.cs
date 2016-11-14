using Nancy;
using Parcel.Objects;
using System;

namespace Parcel
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/form"] = _ => {
                return View["form.cshtml"];
            };
            Get["/parcelDisplay"] =_=> {
                string parcelName = Request.Query["parcel-name"];
                string parcelHeight = Request.Query["parcel-height"];
                string parcelWidth = Request.Query["parcel-width"];
                string parcelLength = Request.Query["parcel-length"];
                string parcelWeight = Request.Query["parcel-weight"];
                string[] formValues = { parcelName, parcelHeight, parcelWidth, parcelLength, parcelWeight};

                if(Array.Exists(formValues, element => element == "")) {
                    return View["form.cshtml"];
                }
                else
                {
                    ParcelObject userParcel = new ParcelObject(parcelName, int.Parse(parcelWeight), int.Parse(parcelHeight), int.Parse(parcelWidth), int.Parse(parcelLength));

                    return View["parcel-display.cshtml", userParcel];
                }
            };
        }
    }
}
