using EventCatalogApi.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogApi.Data
{
    public static class EventSeed
    {
        public static void Seed(EventContext context)
        {
            // before writing data check migratiion is available or not
            context.Database.Migrate();

            // insert data
            // Table EventCategories
            if (!context.EventCategories.Any())
            {
                context.EventCategories.AddRange(GetConfiguredEventCategories());
                context.SaveChanges();
            }

            // Table EventTypes
            if (!context.EventTypes.Any())
            {
                context.EventTypes.AddRange(GetConfiguredEventTypes());
                context.SaveChanges();
            }

            // Table EventDatails
            if (!context.EventDatails.Any())
            {
                context.EventDatails.AddRange(GetConfiguredEventDatails());
                context.SaveChanges();
            }
        }

    
        public static IEnumerable<EventCategory> GetConfiguredEventCategories()
        {
            return new List<EventCategory>
            {
                new EventCategory{Category ="Auto, Boat & Air"},
                new EventCategory{Category="Business & Profressional"},
                new EventCategory{Category="Charity & Causes"},
                new EventCategory{Category="Community & Culture"},
                new EventCategory{Category="family & Education"},
                new EventCategory{Category="Fashion & Beauty"},
                new EventCategory{Category="Film, Media & Entertainment"},
                new EventCategory{Category="Food & Drink"},
                new EventCategory{Category="Government & Politics"},
                new EventCategory{Category="Health & Wellness"},
                new EventCategory{Category="Hobbies & Special Interest"},
                new EventCategory{Category="Home & Lifestyle"},
                new EventCategory{Category="Music"},
                new EventCategory{Category="Music"},
                new EventCategory{Category="Other"},
                new EventCategory{Category="Performing & Visual Arts"},
                new EventCategory{Category="Religion & Spirituality"},
                new EventCategory{Category="School Activities"},
                new EventCategory{Category="Science & Technology"},
                new EventCategory{Category="Seasonal & Holiday"},
                new EventCategory{Category="Sports & Fitness"},
                new EventCategory{Category="Travel & Outdoor"}
            };
        }

        public static IEnumerable<EventType> GetConfiguredEventTypes()
        {
            return new List<EventType>
            {
                new EventType{Type = "Appearance or Signing"},
                new EventType{Type = "Attraction"},
                new EventType{Type = "Camp, Trip, or Retreat"},
                new EventType{Type = "class, Training, or Workshop"},
                new EventType{Type = "Concert or Performance"},
                new EventType{Type = "Conference"},
                new EventType{Type = "Convention"},
                new EventType{Type = "Dinner or Gala"},
                new EventType{Type = "Festival or Fair"},
                new EventType{Type = "Game or Competition"},
                new EventType{Type = "Meeting or Networking Event"},
                new EventType{Type = "Other"},
                new EventType{Type = "Party or Social Gathering"},
                new EventType{Type = "Race or Endurance Event"},
                new EventType{Type = "Rally"},
                new EventType{Type = "Screening"},
                new EventType{Type = "Seminar or Talk"},
                new EventType{Type = "Tour"},
                new EventType{Type = "Tournament"},
                new EventType{Type = "Tradeshow, Consumer Show, or Expo"}
            };
        }

        public static IEnumerable<EventDetail> GetConfiguredEventDatails()
        {
            return new List<EventDetail>
            {
                new EventDetail{ EventCategoryId = 1, OrganizerName  = "Cook is Fun", OrganizerDescription = "It is ok if you are not good at cooking. Cooking is fun.",
                                    LocationName ="Capitol Hill Block Party", City="Seattle", State="WA", Country="U.S.", ZipCode="98122", Address="925 East Pike Street", 
                                    EventTypeId = 3, EventName ="Capitol Hill Block Party 2020", StartDate = new DateTime(2020,5,1, 15,30,00), EndDate= new DateTime(2020, 5, 2, 19,00,00), 
                                    isFree = "Free", isPublic = "Public", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/1",
                                    Description = "Our annual BBQ Tour is heading your way, but this time with a twist. Join us as we celebrate the DIRTYBIRD BIRTHDAY BBQ TOUR 2020! We're happy to be celebrating 15 years of Dirtybird with you. This festival includes bangin' beats, a whole flock of funky friends and some new lineup surprises to come your way!"},

                new EventDetail{ EventCategoryId = 2,
                                    OrganizerName  = "Hiking Yo Mountains", OrganizerDescription = "Usually go hiking in the weekends.",
                                    LocationName ="Lake Union Park", City="Seattle", State="WA", Country="U.S.", ZipCode="98109", Address="860 Terry Ave N", 
                                    EventTypeId = 20, EventName ="Come have fun", StartDate = new DateTime(2020,6,1, 11,30,00), EndDate= new DateTime(2020, 6, 2, 15,00,00), isFree = "Free", isPublic = "Public", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/2",
                                    Description = " Nothing to do on the weekends? Come out to join us for fun!"},

                new EventDetail{ EventCategoryId = 3,
                                    OrganizerName  = "Seattle Green Light", OrganizerDescription = "We are a super cool group that always gather cool people to have fun.",
                                    LocationName ="Seattle Center", City="Seattle", State="WA", Country="U.S.", ZipCode="98109", Address="305 Harrison St", 
                                    EventTypeId = 11, EventName ="Ice Cream 2020", StartDate = new DateTime(2020,7,21, 20,30,00), EndDate= new DateTime(2020, 7, 22, 23,30,00), isFree = "Paid", Price = 120, isPublic = "Public", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/3",
                                    Description = "Do you like ice cream? come and have yummy colorfull ice cream with us! Pets are welcome too."},

                new EventDetail{ EventCategoryId = 4,
                                    OrganizerName  = "Tech for Ladies", OrganizerDescription = "Join us for coding ladies. It is ok to make mistakes. Let's CODE!!",
                                    LocationName ="Hyatt Regency Bellevue", City="Bellevue", State="WA", Country="U.S.", ZipCode="98004", Address="900 Bellevue Way NE", 
                                    EventTypeId = 4, EventName ="Women in Tech 2020", StartDate = new DateTime(2020,6,10, 14,00,00), EndDate= new DateTime(2020, 5, 12, 16,30,00), isFree = "Free", isPublic = "Private", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/4",
                                    Description = "We are happy to know you!"},

                new EventDetail{ EventCategoryId = 5,
                                    OrganizerName  = "Tech for Ladies", OrganizerDescription = "Join us for coding ladies. It is ok to make mistakes. Let's CODE!!",
                                    LocationName ="The Crocodile", City="Seattle", State="WA", Country="U.S.", ZipCode="98121", Address="2200 2nd Avenue", 
                                    EventTypeId = 5, EventName ="Coders King", StartDate = new DateTime(2020,7,12, 12,30,00), EndDate= new DateTime(2020, 7, 13, 14,30,00), isFree = "Free", isPublic = "Public", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/5",
                                    Description = "Do you want to build a creazy project? Come and join us today!"},

                new EventDetail{ EventCategoryId = 6,
                                    OrganizerName  = "Ice Cream Cats", OrganizerDescription = "Join us for yummy sweets!!",
                                    LocationName ="Lynnwood Convention Center", City="Lynnwood", State="WA", Country="U.S.", ZipCode="98036", Address="3711 196th Street Southwest", 
                                    EventTypeId = 6, EventName ="Party to Die 2020", StartDate = new DateTime(2020,8,1, 10,30,00), EndDate= new DateTime(2020, 9, 2, 23,30,00), isFree = "Paid", Price = 49, isPublic = "Private", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/6",
                                    Description = "Wanna meet some new friends? Here is a party for you to die!"},

                new EventDetail{ EventCategoryId = 7,
                                    OrganizerName  = "Bikers on the Road", OrganizerDescription = "We are bikers always on the road. ",
                                    LocationName ="Eastside Foursquare Church", City="Bothell", State="WA", Country="U.S.", ZipCode="98011", Address="14520 100th Ave NE", 
                                    EventTypeId = 7, EventName ="200 Gates", StartDate = new DateTime(2020,7,1, 15,30,00), EndDate= new DateTime(2020, 7, 2, 22,30,00), isFree = "Free", isPublic = "Public", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/7",
                                    Description = "Serious science!"},

                new EventDetail{ EventCategoryId = 8,
                                    OrganizerName  = "Seattle Green Light", OrganizerDescription = "We are a super cool group that always gather cool people to have fun.",
                                    LocationName ="Museum of Pop Culture", City="Seattle", State="WA", Country="U.S.", ZipCode="98109", Address="325 5th Avenue N", 
                                    EventTypeId = 8, EventName ="City Music", StartDate = new DateTime(2020,10,1, 13,30,00), EndDate= new DateTime(2020, 10, 2, 22,30,00), isFree = "Paid", Price = 200, isPublic = "Public", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/8",
                                    Description = "30 Bands will be here for you. Let's rock!"},

                new EventDetail{ EventCategoryId = 1,
                                    OrganizerName = "Party to Die", OrganizerDescription = "We are party animals!!!",
                                    LocationName  = "Lake Union Park", City="Seattle", State="WA", Country="U.S.", ZipCode="98109", Address="860 Terry Ave N", 
                                    EventTypeId = 9, EventName ="DJ to Roll 2021", StartDate = new DateTime(2020,5,15, 21,00,00), EndDate= new DateTime(2020, 5, 16, 23,00,00),isFree = "Free", isPublic = "Public", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/9",
                                    Description = "Our new DJ will be here for ya! Come with your soul!"},

                new EventDetail{ EventCategoryId = 9,
                                    OrganizerName = "Fast & Furious", OrganizerDescription = "Loser walks home.",
                                    LocationName = "Seattle Center", City="Seattle", State="WA", Country="U.S.", ZipCode="98109", Address="305 Harrison St", 
                                    EventTypeId = 10, EventName ="We Own it!!!", StartDate = new DateTime(2020,8,1, 15,00,00), EndDate= new DateTime(2020, 8, 1, 18,30,00), isFree = "Free", isPublic = "Public", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/10",
                                    Description = "Big fun of racing? We Own It!"},

                new EventDetail{ EventCategoryId = 3,
                                    OrganizerName  = "Science water for experiments", OrganizerDescription = "We do fun experiments.Dont be shy. Come and join us TODAY!!!",
                                    LocationName ="Seattle Center", City="Seattle", State="WA", Country="U.S.", ZipCode="98109", Address="305 Harrison St", 
                                    EventTypeId = 13, EventName ="Next Level 2020", StartDate = new DateTime(2020,9,17, 18,00,00), EndDate= new DateTime(2020, 9, 18, 23,30,00), isFree = "Paid", Price = 59, isPublic = "Private", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/11",
                                    Description = "Nothing to say! Experiments are fun!"},

                new EventDetail{ EventCategoryId = 5,
                                    OrganizerName  = "Fast & Furious", OrganizerDescription = "Loser walks home.",
                                    LocationName ="Lake Union Park", City="Seattle", State="WA", Country="U.S.", ZipCode="98109", Address="860 Terry Ave N", 
                                    EventTypeId = 12, EventName ="Fate & Furious", StartDate = new DateTime(2020,5,1, 18,30,00), EndDate= new DateTime(2020, 5, 2, 23,30,00), isFree = "Paid", Price = 150, isPublic = "Public", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/12",
                                    Description = "Big fun of the Rock? Let's go race!"},

                new EventDetail{ EventCategoryId = 4,
                                    OrganizerName  = "Fast & Furious", OrganizerDescription = "Loser walks home.",
                                    LocationName ="Lake Union Park", City="Seattle", State="WA", Country="U.S.", ZipCode="98109", Address="860 Terry Ave N",
                                    EventTypeId = 17, EventName ="Ready to rece 2020", StartDate = new DateTime(2020,6,12, 19,00,00), EndDate= new DateTime(2020, 6, 13, 23,30,00), isFree = "Free", isPublic = "Private", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/13",
                                    Description = "Get your car ready! Loser walks home."},

                new EventDetail{ EventCategoryId = 2,
                                    OrganizerName  = "Tech for Ladies", OrganizerDescription = "Join us for coding ladies. It is ok to make mistakes. Let's CODE!!",
                                    LocationName ="Seattle Center", City="Seattle", State="WA", Country="U.S.", ZipCode="98109", Address="305 Harrison St", 
                                    EventTypeId = 18, EventName ="Nothing to do? Let's CODE!", StartDate = new DateTime(2020,7,27, 10,30,00), EndDate= new DateTime(2020, 7, 28, 14,30,00), isFree = "Free", isPublic = "Public", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/14",
                                    Description = "meet our smart coders!"}
            };
        }
    } 
}
