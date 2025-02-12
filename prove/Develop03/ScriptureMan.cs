class ScriptureMan
{
    // Attribute Declaration
    private List<Scripture> _scriptures = new List<Scripture>();

    // Constructor Declaration
    public ScriptureMan()
    {
        _scriptures.Add(new Scripture("Alma 26:26-27", "But behold, my beloved brethren, we came into the wilderness not with the intent to destroy our brethren, but with the intent that perhaps we might save some few of their souls.|Now when our hearts were depressed, and we were about to turn back, behold, the Lord comforted us, and said: Go amongst thy brethren, the Lamanites, and bear with patience thine afflictions, and I will give unto you success."));
        _scriptures.Add(new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding.|In all thy ways acknowledge him, and he shall direct thy paths."));
        _scriptures.Add(new Scripture("Matthew 7:19-21", "19 Every tree that bringeth not forth good fruit is hewn down, and cast into the fire.|Wherefore by their fruits ye shall know them.|Not every one that saith unto me, Lord, Lord, shall enter into the kingdom of heaven; but he that doeth the will of my Father which is in heaven."));
    }

    // Module Declaration
    public Scripture chooseRandomScripture()
    {
        Random random = new Random();
        int chosen_scripture = random.Next(_scriptures.Count);
        return _scriptures[chosen_scripture];
    }
}