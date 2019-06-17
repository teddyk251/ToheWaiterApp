using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaiterAPI.Models;
namespace WaiterAPI.Repository
{
    public interface ISelectCategory
    {
        List<Element> selectCatagory(string catID);
    }
}
