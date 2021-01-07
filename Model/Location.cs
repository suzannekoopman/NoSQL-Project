using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public enum Location
    {
        Rotterdam, [Display(Name = "Den Haag")] DenHaag, Zoetermeer, Leiden, Dordrecht,
        [Display(Name = "Alphen aan de Rijn")] Alphen, Westland, Delft, Utrecht, Amersfoort,
        Amsterdam, Haarlem, Zaanstad, Haarlemmermeer, Alkmaar, Almere
    }
}
