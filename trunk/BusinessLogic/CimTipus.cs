using System;

namespace BusinessLogic
{
    public enum CimTipus
    {
        [StringValue("Székhely")]
        szekhely = 1,
        [StringValue("Állandó lakcím")]
        allandolakcim = 2,
        [StringValue("Levelezési cím")]
        levelezcim = 3,
        [StringValue("Tartózkodási hely")]
        tarthely = 4


    }
}
