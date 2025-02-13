class ScriptureMan
{
    // Attribute Declaration
    private List<Scripture> _scriptures = new List<Scripture>();

    // Constructor Declaration
    public ScriptureMan() // Verses are parsed by the divider character "|".
    {
        // Template: _scriptures.Add(new Scripture("TEMPLATE", CHAPTER NUMBER, VERSE START NUMBER, VERSE END NUMBER, "SCRIPTURE CONTENT HERE"));
        _scriptures.Add(new Scripture("Alma", 26, 26, 27, "But behold, my beloved brethren, we came into the wilderness not with the intent to destroy our brethren, but with the intent that perhaps we might save some few of their souls.|Now when our hearts were depressed, and we were about to turn back, behold, the Lord comforted us, and said: Go amongst thy brethren, the Lamanites, and bear with patience thine afflictions, and I will give unto you success."));
        _scriptures.Add(new Scripture("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.|In all thy ways acknowledge him, and he shall direct thy paths."));
        _scriptures.Add(new Scripture("Matthew", 7, 19, 21, "Every tree that bringeth not forth good fruit is hewn down, and cast into the fire.|Wherefore by their fruits ye shall know them.|Not every one that saith unto me, Lord, Lord, shall enter into the kingdom of heaven; but he that doeth the will of my Father which is in heaven."));
        _scriptures.Add(new Scripture("1 Nephi", 16, 29, 29, "And there was also written upon them a new writing, which was plain to be read, which did give us understanding concerning the ways of the Lord; and it was written and changed from time to time, according to the faith and diligence which we gave unto it. And thus we see that by small means the Lord can bring about great things."));
        _scriptures.Add(new Scripture("Ether", 4, 12, 12, "And whatsoever thing persuadeth men to do good is of me; for good cometh of none save it be of me. I am the same that leadeth men to all good; he that will not believe my words will not believe me—that I am; and he that will not believe me will not believe the Father who sent me. For behold, I am the Father, I am the light, and the life, and the truth of the world."));
        _scriptures.Add(new Scripture("Mosiah", 5, 7, 7, "And now, because of the covenant which ye have made ye shall be called the children of Christ, his sons, and his daughters; for behold, this day he hath spiritually begotten you; for ye say that your hearts are changed through faith on his name; therefore, ye are born of him and have become his sons and his daughters."));
        _scriptures.Add(new Scripture("Alma", 14, 11, 11, "But Alma said unto him: The Spirit constraineth me that I must not stretch forth mine hand; for behold the Lord receiveth them up unto himself, in glory; and he doth suffer that they may do this thing, or that the people may do this thing unto them, according to the hardness of their hearts, that the judgments which he shall exercise upon them in his wrath may be just; and the blood of the innocent shall stand as a witness against them, yea, and cry mightily against them at the last day."));
        _scriptures.Add(new Scripture("1 Corinthians", 6, 19, 20, "What? know ye not that your body is the temple of the Holy Ghost which is in you, which ye have of God, and ye are not your own?|For ye are bought with a price: therefore glorify God in your body, and in your spirit, which are God's."));
        _scriptures.Add(new Scripture("Helaman", 11, 4, 5, "O Lord, do not suffer that this people shall be destroyed by the sword; but O Lord, rather let there be a famine in the land, to stir them up in remembrance of the Lord their God, and perhaps they will repent and turn unto thee.|And so it was done, according to the words of Nephi. And there was a great famine upon the land, among all the people of Nephi. And thus in the seventy and fourth year the famine did continue, and the work of destruction did cease by the sword but became sore by famine."));
        _scriptures.Add(new Scripture("Helaman", 3, 29, 30, "Yea, we see that whosoever will may lay hold upon the word of God, which is quick and powerful, which shall divide asunder all the cunning and the snares and the wiles of the devil, and lead the man of Christ in a strait and narrow course across that everlasting gulf of misery which is prepared to engulf the wicked—|And land their souls, yea, their immortal souls, at the right hand of God in the kingdom of heaven, to sit down with Abraham, and Isaac, and with Jacob, and with all our holy fathers, to go no more out."));
    }

    // Module Declaration
    public Scripture ChooseRandomScripture()
    {
        Random random = new Random();
        int chosen_scripture = random.Next(_scriptures.Count);
        return _scriptures[chosen_scripture];
    }
}