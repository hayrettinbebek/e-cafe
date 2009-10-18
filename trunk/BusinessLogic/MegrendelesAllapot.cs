using System;


namespace BusinessLogic
{
    public enum MegrendelesAllapot
    {
        [StringValue("Nyitott")]
        mobil = 0,
        [StringValue("Elküldött/Bevételezhető")]
        email = 1,
        [StringValue("Bevételezett")]
        vezetekes = 2

    }
}
