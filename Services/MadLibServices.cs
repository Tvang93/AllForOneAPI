using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOneAPI.Models;

namespace AllForOneAPI.Services
{
    public class MadLibServices
    {
        public List<MadLibFillIn> MadLibItems = [
            new MadLibFillIn {
                Animal = "insert an animal",
                Container = "inser some type of container",
                LeastFavColor = "insert your least favorite color",
                BodyCovering = "insert a type of material coving an animal's body",
                Verb = "insert a verb or action",
                FavoriteThing = "insert your favorite material object or thing",
                FavoriteFood = "insert your favorite food",
                ActivityToDo = "insert something you would like to do but never done",
                ChangeAppearance = "insert a way to chane your appearance",
                FavColor = "insert your favorite color",
            }
        ];

        // public List<MadLibFillIn> GetMadLibFillIns()
        // {
        //     return MadLibItems;
        // }

        public string AddMadLib(MadLibFillIn madLibFillIn)
        {
            return $"Once upon a time, in a land far far away, there once was a {madLibFillIn.Animal} that lived in a {madLibFillIn.Container}. A {madLibFillIn.Animal} with {madLibFillIn.LeastFavColor} {madLibFillIn.BodyCovering}. A {madLibFillIn.LeastFavColor} {madLibFillIn.Animal} that could {madLibFillIn.Verb}. People from around the world would come visit this {madLibFillIn.Animal}, bringing {madLibFillIn.FavoriteThing} and {madLibFillIn.FavoriteFood}. Night and day, people would ask the {madLibFillIn.Animal} to {madLibFillIn.Verb} for them, and the {madLibFillIn.Animal}, showered with such luxuries, would comply. However, after many years, the {madLibFillIn.Animal} got tired of having to {madLibFillIn.Verb}. Tired of the {madLibFillIn.FavoriteFood}. Tired of all the {madLibFillIn.FavoriteThing}. The {madLibFillIn.Animal} wanted to go {madLibFillIn.ActivityToDo}, but with so many people constantly showing up and offering {madLibFillIn.FavoriteThing} and {madLibFillIn.FavoriteFood}, the {madLibFillIn.Animal} would never have the time. So the {madLibFillIn.Animal} came up with a plan. They would {madLibFillIn.ChangeAppearance}. However, even after that the {madLibFillIn.Animal} was still recognized, so the {madLibFillIn.Animal} had to come up with an even more extreme method: changing its {madLibFillIn.BodyCovering} color. The {madLibFillIn.Animal} turned its {madLibFillIn.BodyCovering} {madLibFillIn.FavColor}, finally allowing the {madLibFillIn.Animal} to go {madLibFillIn.ActivityToDo} or anything else they wanted to do.";
        }
    }
}