using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ULAPP.Pages
{
  public class LineItem
  {
    public string Line { get; set; }
    public string Description { get; set; }
  }
  public class PoemModel : PageModel
  {
    public string ElementName;
    public string Title;
    public List<LineItem> Lines;

    public void OnGet()
    {
      Title = "the mini power pack";
      ElementName = "LITHIUM, Li";
      Lines = new List<LineItem>
      {
        new LineItem()
        {
          Line = "Li, small and light, the soft metal with mettle!",
          Description = "Lithium is the soft, silvery-white metal at the top of the alkali metals in group 1 of the periodic table. It’s the smallest of the alkali metals and the lightest of all metals. Lithium is one of only three elements (and the only metal) that can trace its roots back to the Big Bang; the other two are the gaseous elements hydrogen and helium. For much of its existence, lithium has been overlooked in terms of practical applications. But in more recent times the element has assumed a far more prominent role in our everyday lives (see the next line of the poem)."
        },
        new LineItem()
        {
          Line = "Keeps much of our mobile-power’d world in good fettle;",
          Description = "Lithium-ion batteries are so compact and light they’ve become the power source for most rechargeable, lightweight, mobile electronic devices, such as phones, MP3 players, laptops, notebooks, and tablets. Lithium ion batteries can also store significant amounts of energy from solar and wind power, opening new possibilities for fossil fuel–free energy. For this reason, John B. Goodenough, M. Stanley Whittingham, and Akira Yoshino received the 2019 Nobel Prize in Chemistry for the development of lithium-ion batteries."
        },        
        new LineItem()
        {
          Line = "In the sea and the soil,",
          Description = "Lithium is the 31st most abundant element in Earth’s crust. It’s found at approximately 40 parts per million (ppm) in soil and 0.17 ppm in seawater."
        },        
        new LineItem()
        {
          Line = "Floats on water and oil,",
          Description = "Because lithium metal is so light, it floats on water. In fact, it reacts vigorously with water, whizzing about frantically and shrinking as it produces hydrogen gas (H2), which sometimes ignites due to the heat liberated during the reaction. It also floats on oil, meaning that it must be coated in Vaseline (petroleum jelly) to be stored safely and protected from contact with water and oxygen!"
        },        
        new LineItem()
        {
          Line = "Has often helped many’s the troubled mind settle.",
          Description = "When taken in tablet form as lithium carbonate (Li2CO3), the tiny lithium ion (Li+) is a powerfully effective mood stabilizer for those with bipolar disorder."
        }
      };



    }
  }
}
