namespace FlavorNet.Data
{

    /// <summary>
    /// Generates desired number of random contacts.
    /// </summary>
    public class SeedDatabase
    {
             private List<Review> MakeReviews()
        {
            List<Review> reviewList = new List<Review>
        {
            new Review
            {
                Reviewer = "Eleanor Henderson",
                Comment = "I must say, my experience at your restaurant was nothing short of exceptional. From the moment I walked through the door, I was greeted with a warm and inviting atmosphere that set the perfect tone for the evening. The food, without a doubt, was a culinary masterpiece. Every dish was a symphony of flavors, beautifully presented and expertly prepared. The service was impeccable; the staff's attention to detail and genuine passion for what they do shone through in every interaction. I was particularly impressed with the extensive wine list, which offered a delightful complement to my meal. Kudos to your sommelier! This dining experience was a true delight, and I look forward to returning soon."
            },
            new Review
            {
                Reviewer = "Samuel Rodriguez",
                Comment = "I wanted to take a moment to express my gratitude for the wonderful time I had at your restaurant. The ambiance was charming, and it immediately transported me to a world of culinary delight. As a vegetarian, I often struggle to find restaurants that cater to my dietary preferences, but your menu truly impressed me. The array of plant-based options was not only extensive but also creatively crafted. I sampled a variety of dishes, each bursting with unique flavors and textures. The thoughtfulness in accommodating different dietary needs was evident. Your restaurant has earned a special place in my heart, and I can't wait to explore more of your delightful offerings."
            },
            new Review
            {
                Reviewer = "Oliver Reynolds",
                Comment = "I recently had the pleasure of dining at your establishment, and I must say, I was blown away by the chef's creativity and culinary prowess. The daily special was a revelation – a symphony of flavors that danced on my taste buds. It's not often that one encounters such a unique and delightful combination of ingredients. The attention to detail in every aspect of the meal, from the presentation to the taste, was truly remarkable. It's evident that your culinary team is passionate about their craft, and it reflects in every dish. My compliments to the chef for providing a dining experience that exceeded my expectations."
            },
            new Review
            {
                Reviewer = "Sophia Baker",
                Comment = "I wanted to express my heartfelt appreciation for the exceptional brunch experience I had at your restaurant. It was a special occasion for my family, and your restaurant made it even more memorable. The brunch menu was a treasure trove of delectable options, catering to a wide range of palates. What truly stood out, however, was the thought put into the kids' menu. As a parent, finding a place where my little ones can enjoy a meal while we indulge in culinary delights is a rare find. The friendly and attentive staff made the experience even more enjoyable. Thank you for providing the perfect setting for our family celebration."
            },
            new Review
            {
                Reviewer = "Nathaniel Harper",
                Comment = "I've been a loyal patron of your restaurant for quite some time, and with each visit, I am reminded of why I keep coming back. Your commitment to excellence in every aspect of the dining experience is truly commendable. The consistency in the quality of food is remarkable, and it's evident that your kitchen is dedicated to delivering nothing but the best. Beyond the culinary delights, the service is always exceptional. The staff's knowledge of the menu, their attention to detail, and their genuine enthusiasm for ensuring a memorable visit make every meal a pleasure. Thank you for maintaining such high standards."
            },
            new Review
            {
                Reviewer = "Isabella Martinez",
                Comment = "I simply couldn't resist indulging in the delectable dessert selection at your restaurant, and I must say, it was an absolute delight for my taste buds. The chocolate lava cake, in particular, was a piece of heaven on a plate. The rich, molten chocolate oozing out was a sight to behold, and the taste was even more heavenly. It's not just a dessert; it's an experience in itself. Your pastry chef deserves all the accolades for creating such a masterpiece. I left your restaurant with a sweet smile on my face and a craving for more. I'll be dreaming of that dessert for days to come!"
            },
            new Review
            {
                Reviewer = "Lucas Anderson",
                Comment = "I wanted to commend your restaurant for its outstanding customer service. I had a minor dietary restriction during my recent visit, and I was pleasantly surprised by how accommodating your staff was. They not only understood my dietary needs but also went above and beyond to create a customized meal that exceeded my expectations. It's rare to find such flexibility and attentiveness in a restaurant. Your commitment to ensuring that every guest has a memorable dining experience is truly commendable. Thank you for taking care of your patrons in such a thoughtful manner."
            },
            new Review
            {
                Reviewer = "Mia Thompson",
                Comment = "I'm an avid wine enthusiast, and I was thoroughly impressed by your restaurant's wine list. It's evident that a lot of thought and expertise have gone into curating this selection. The range of varietals and vintages available was impressive, and it added a whole new dimension to my dining experience. What made the evening even more special was the sommelier's recommendations. Their knowledge and passion for wine shone through as they guided me through the perfect wine pairings for my meal. It was a memorable journey for my palate, and I can't wait to return to explore more of your wine offerings."
            },
            new Review
            {
                Reviewer = "Benjamin Wright",
                Comment = "I recently had the pleasure of hosting a private event at your restaurant, and it was an absolute success. I would like to extend my gratitude to your event coordinator, who went above and beyond to ensure that every detail was meticulously handled. The venue itself provided the perfect backdrop for our gathering, with its elegant and inviting ambiance. Our guests were thoroughly impressed, not only by the setting but also by the impeccable service and, of course, the exceptional cuisine. Thank you for making our event truly memorable; your restaurant will always be our first choice for future gatherings."
            },
            new Review
            {
                Reviewer = "Ava Clark",
                Comment = "I had the most delightful dining experience at your restaurant, and I felt compelled to share my enthusiasm. From the moment I stepped in, I was greeted by an ambiance that exuded warmth and sophistication. It set the stage for what turned out to be a culinary journey like no other. Each dish was a masterpiece, a blend of flavors and textures that was nothing short of perfection. What truly stood out was the impeccable service; the staff's attention to detail and their genuine passion for hospitality made the evening truly special. Your restaurant is a hidden gem, and I can't wait to return to explore more of your culinary offerings."
            },
            // Bad
            new Review
            {
                Reviewer = "Robert Johnson",
                Comment = "My recent visit to your restaurant was quite disappointing, to say the least. The food quality has noticeably declined since my last visit. The dish I ordered was undercooked, and the flavors were completely off. It was a far cry from the delicious meals I had enjoyed here before. The service was equally disappointing, with slow and inattentive staff. This experience has left me reconsidering whether I'll be returning anytime soon."
            },
            new Review
            {
                Reviewer = "Linda Williams",
                Comment = "I regret to inform you that my dining experience at your restaurant was far from satisfactory. The ambiance was marred by noisy patrons, making it difficult to have a decent conversation. Moreover, the cleanliness of the dining area left much to be desired, which was quite off-putting. As for the food, it was bland and uninspiring. It lacked the flavors and creativity I had expected from a restaurant of your reputation. I left feeling disappointed and unlikely to recommend your establishment to others."
            },
            new Review
            {
                Reviewer = "George Davis",
                Comment = "I had the unfortunate experience of dining at your restaurant last night, and I must say, it was a letdown. The service was abysmal; our waiter seemed disinterested and had a condescending attitude. The wait times for our dishes were excessive, and when they finally arrived, they were overcooked and tasteless. The overall dining experience was tarnished by these issues, and I have no intention of returning."
            },
            new Review
            {
                Reviewer = "Megan Smith",
                Comment = "My recent visit to your restaurant was a complete disappointment. The presentation of the dishes was lackluster, and the taste didn't make up for it either. The food was bland and lacked seasoning, leaving me with an unsatisfied palate. To make matters worse, the portion sizes were meager for the price we paid. I expected more from a restaurant with such high ratings, and unfortunately, I won't be recommending it to others."
            },
            new Review
            {
                Reviewer = "William Turner",
                Comment = "I had high hopes when I decided to dine at your restaurant, but I left feeling thoroughly disappointed. The menu was limited, and the dishes I ordered were a letdown. They lacked the freshness and flavor I anticipated. The service was unacceptably slow, and our server seemed indifferent to our concerns. This dining experience was far from what I had hoped for, and I won't be returning."
            },
            new Review
            {
                Reviewer = "Sophie Walker",
                Comment = "I recently visited your restaurant, and it pains me to say that it was a regrettable experience. The atmosphere was chaotic, with noisy patrons and a lack of proper spacing between tables. The staff appeared overwhelmed and unorganized, resulting in long delays in receiving our orders. When the food finally arrived, it was cold and tasted like it had been reheated. It's disheartening to see a restaurant with potential fall so short of expectations."
            },
            new Review
            {
                Reviewer = "Michael Brown",
                Comment = "My visit to your restaurant was nothing short of disappointing. The dining area was unkempt, with dirty tables and a general lack of cleanliness. The food quality was subpar, with a lack of seasoning and flavor. It's evident that there's a need for improvement in both the kitchen and front-of-house operations. I wouldn't recommend this establishment to anyone seeking a quality dining experience."
            },
            new Review
            {
                Reviewer = "Emily Harris",
                Comment = "I had the misfortune of dining at your restaurant recently, and it left me thoroughly dissatisfied. The service was slow, and our server seemed disinterested in our needs. The food, when it finally arrived, was disappointing. It lacked the depth of flavors and creativity I had anticipated based on the menu descriptions. The overall experience was underwhelming, and I won't be returning in the future."
            },
            new Review
            {
                Reviewer = "Daniel Miller",
                Comment = "I had heard positive reviews about your restaurant, so my expectations were high. However, my experience was a significant letdown. The food was unappetizing, and the presentation lacked finesse. The waitstaff appeared disorganized, and we had to wait an unacceptable amount of time for our orders. I left your establishment with a sense of disappointment, and I won't be returning."
            },
            new Review
            {
                Reviewer = "Olivia Clark",
                Comment = "My recent visit to your restaurant was a complete disappointment. The ambiance was far from inviting, with a lack of proper lighting and decor. The menu options were limited and uninspiring. When the dishes arrived, they were poorly prepared and lacked flavor. The service was equally lackluster, with inattentive staff. This experience was a stark contrast to my expectations, and I won't be recommending your restaurant to others."
            },
            // ok

                        new Review
            {
                Reviewer = "John Smith",
                Comment = "My recent dining experience at your restaurant was neither exceptional nor disappointing. The ambiance was pleasant, and the staff was courteous. The food was decent, but it didn't stand out as extraordinary. Overall, it was an average dining experience."
            },
            new Review
            {
                Reviewer = "Sarah Davis",
                Comment = "I visited your restaurant recently and wanted to share a neutral perspective. The atmosphere was comfortable, and the service was efficient. The menu offered a variety of options, and the food was prepared adequately. While it wasn't the most memorable dining experience, it certainly met my expectations."
            },
            new Review
            {
                Reviewer = "James Wilson",
                Comment = "I dined at your restaurant, and I have mixed feelings about the experience. The decor was pleasing, and the staff was friendly. However, the food, while decent, didn't leave a lasting impression. It was neither remarkable nor disappointing. It was an average meal."
            },
            new Review
            {
                Reviewer = "Emma Johnson",
                Comment = "I visited your establishment recently and found it to be a moderate experience. The ambiance was comfortable, and the service was prompt. The menu had a reasonable selection, and the food was prepared satisfactorily. It wasn't exceptional, but it wasn't below par either."
            },
            new Review
            {
                Reviewer = "Michael Brown",
                Comment = "My dining experience at your restaurant can be described as neutral. The atmosphere was pleasant, and the service was adequate. The food was decent, but it didn't leave a strong impression. It was an average meal, and I neither regret nor particularly cherish the experience."
            },
            new Review
            {
                Reviewer = "Sophie Martin",
                Comment = "I wanted to provide a neutral review of my recent visit to your restaurant. The decor was nice, and the staff was polite. The menu had a variety of options, and the food was prepared decently. It wasn't a standout experience, but it wasn't disappointing either."
            },
            new Review
            {
                Reviewer = "David Lee",
                Comment = "I dined at your restaurant, and my experience was middle-of-the-road. The ambiance was pleasant, and the service was satisfactory. The menu had a decent selection, and the food was prepared adequately. It wasn't a memorable dining experience, but it was acceptable."
            },
            new Review
            {
                Reviewer = "Emily Thomas",
                Comment = "My recent visit to your restaurant was unremarkable. The atmosphere was comfortable, and the staff was courteous. The menu had a variety of options, and the food was prepared decently. It was a typical dining experience, without any notable highs or lows."
            },
            new Review
            {
                Reviewer = "William Turner",
                Comment = "I visited your establishment and found it to be a neutral experience. The decor was pleasant, and the staff was friendly. The menu had a reasonable selection, and the food was prepared satisfactorily. It wasn't an extraordinary meal, but it wasn't disappointing either."
            },
            new Review
            {
                Reviewer = "Olivia Clark",
                Comment = "My recent dining experience at your restaurant was neither exceptional nor disappointing. The ambiance was comfortable, and the staff was courteous. The food was decent, but it didn't stand out as extraordinary. Overall, it was an average dining experience."
            }
        };
            return reviewList;
        }

        public async Task SeedDatabaseWithReviewCountOfAsync(FlavorContext context, int totalCount)
        {

            var list = MakeReviews();

            if (list.Count > 0)
            {
                context.Reviews?.AddRange(list);
                await context.SaveChangesAsync();
            }
        }
        
    }
}