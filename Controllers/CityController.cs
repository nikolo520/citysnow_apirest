using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apirest_webapp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : ControllerBase
    {
        [HttpGet("{name}")]
        public ActionResult Get(string name)
        {
            if (name == "Cali")
            {
                return Ok(
                    new object[]
                    {
                        new {
                            status=true,
                            message="Consulta exitosa",
                            articles= new object[]
                            {
                                new { 
                                    source="CNET",
                                    author="Oscar Gonzalez",
                                    title="Ivermectin and COVID-19: What you need to know about this unproven drug - CNET",
                                    description="People continue taking a horse dewormer, thinking it's a treatment for COVID.",
                                    url="https://www.cnet.com/news/ivermectin-and-covid-19-what-you-need-to-know-about-this-unproven-drug/",
                                    urlToImage="https://www.cnet.com/a/img/jgMwIpj1Y4dBv1x5aRPszuEYARY=/1200x630/2021/09/03/7f8189e9-fc00-4502-bb9c-a1c22dfc66b3/gettyimages-1235007289.jpg"
                                }
                            },
                            weather= new{icon = "02d",temp=29,temp_min=22,temp_max=30,pressure=1000,humidity=320,feels_like=29}
                        }
                    });
            }
        
            else if(name =="Ibague")
            {
                return Ok(
                    new object[]
                    {
                        new {
                            status=true,
                            message="Consulta exitosa",
                            articles= new object[]
                            {
                                new {
                                    source="Reuters",
                                    author="",
                                    title="Families of protesters killed in Colombia face long wait for justice - Reuters",
                                    description="It has been a year since Carolina Hurtado rushed to a hospital morgue in Colombia's capital to identify the bloodied body of her older brother Cristhian, but she still has no definitive answers about how he was killed.",
                                    url="https://www.reuters.com/world/americas/families-protesters-killed-colombia-face-long-wait-justice-2021-09-10/",
                                    urlToImage="https://www.reuters.com/resizer/nvL90lqTOykZo4R_A-9A2jijxVY=/1200x628/smart/filters:quality(80)/cloudfront-us-east-2.images.arcpublishing.com/reuters/5DZV6FKD6BN2PJUYISCSM2OWBE.jpg"
                                }
                            },
                            weather= new{icon = "02d",temp=28,temp_min=20,temp_max=28,pressure=1000,humidity=320,feels_like=29}
                        }
                    });
            }
            else if (name == "New York")
            {
                return Ok(
                    new object[]
                    {
                        new {
                            status=true,
                            message="Consulta exitosa",
                            articles= new object[]
                            {
                                new {
                                    source="Lifehacker.com",
                                    author="Elizabeth Yuko",
                                    title="How to Stage the Attic When You're Trying to Sell Your House",
                                    description="There’s a lot to think about when your house is on the market, including how to stage it. Maybe your home is already perfectly organized, decorated in neutrals, and devoid of any personal photos. But for everyone else, staging your home is work.Read more...",
                                    url="https://lifehacker.com/how-to-stage-the-attic-when-youre-trying-to-sell-your-h-1847745488",
                                    urlToImage="https://i.kinja-img.com/gawker-media/image/upload/c_fill,f_auto,fl_progressive,g_center,h_675,pg_1,q_80,w_1200/d8146338ace14dd53b55d1d02ae99dfc.jpg"
                                }
                            },
                            weather= new{icon = "02d",temp=26,temp_min=21,temp_max=28,pressure=1000,humidity=320,feels_like=29}
                        }
                    });
            }
            else
            {
                return Ok(
                    new object[]
                    {
                        new {
                            status=false,
                            message="No se encontró información",
                        }
                    });
            }
        }


    }
}
