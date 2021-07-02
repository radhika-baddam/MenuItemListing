using MenuItemListing.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        /*List<MenuItem> l = new List<MenuItem>()
            {
                new MenuItem() {Id=101,Name="First",Price=500,Active=true,FreeDelivery=false,DateOfLaunch=new DateTime(2020, 09, 23, 16, 45, 0) },
                new MenuItem() {Id=102,Name="Second",Price=100,Active=false,FreeDelivery=false,DateOfLaunch=new DateTime(2021, 07, 25, 5, 31, 0) },
                new MenuItem() {Id=103,Name="Third",Price=650,Active=false,FreeDelivery=true,DateOfLaunch=new DateTime(2019, 05, 31, 12, 15, 0) },
                new MenuItem() {Id=104,Name="Fourth",Price=700,Active=true,FreeDelivery=true,DateOfLaunch=new DateTime(2013, 12, 31, 9, 56, 0) },
                new MenuItem() {Id=105,Name="Fifth",Price=770,Active=true,FreeDelivery=true,DateOfLaunch=new DateTime(2018, 12, 31, 21, 56, 0) }
            };*/

       [HttpGet]
       public List<MenuItem> getList()
        {
            List<MenuItem> l = new List<MenuItem>()
            {
                new MenuItem() {Id=101,Name="First",Price=500,Active=true,freeDelivery=false,dateOfLaunch=new DateTime(2020, 09, 23, 16, 45, 0) },
                new MenuItem() {Id=102,Name="Second",Price=100,Active=false,freeDelivery=false,dateOfLaunch=new DateTime(2021, 07, 25, 5, 31, 0) },
                new MenuItem() {Id=103,Name="Third",Price=650,Active=false,freeDelivery=true,dateOfLaunch=new DateTime(2019, 05, 31, 12, 15, 0) },
                new MenuItem() {Id=104,Name="Fourth",Price=700,Active=true,freeDelivery=true,dateOfLaunch=new DateTime(2013, 12, 31, 9, 56, 0) },
                new MenuItem() {Id=105,Name="Fifth",Price=770,Active=true,freeDelivery=true,dateOfLaunch=new DateTime(2018, 12, 31, 21, 56, 0) }
            };
            return l;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> getItem(int id)
        {
            List<MenuItem> l = this.getList();
            foreach (MenuItem i in l)
            {
                if(i.Id==id)
                {
                    return i.Name;
                }
            }
            return NotFound();
        }


    }
}
