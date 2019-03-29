using System;
using System.Collections.Generic;

namespace DogKennel
{
    /// <summary>
    /// Cобачка
    /// </summary>
    public class Dog
    {
        /// <summary>
        /// Порода
        /// </summary>
        public Breed Breed { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Фотография
        /// </summary>
        public byte[] Photo { get; set; }

        /// <summary>
        /// Цена в рублях
        /// </summary>
        public int CostInRubles { get; set; }

        /// <summary>
        /// Дополнительная информация 
        /// </summary>
        public List<AdditionalInformation> AdditionalInformation { get; set; }
        
        /// <summary>
        /// Журнал достижений на выставках (если имеются)
        /// </summary>
        public List<Achievement> AchievementJournal{ get; set; }
    }

    /// <summary>
    /// Порода
    /// </summary>
    public enum Breed
    {
        /// <summary>
        /// Золотистый ретривер
        /// </summary>
        GoldenRetriever,
        /// <summary>
        /// Лабрадор
        /// </summary>
        Labrador,
        /// <summary>
        /// Ротвейлер
        /// </summary>
        Rottweiler
    }

    /// <summary>
    /// Пол
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// Мальчик
        /// </summary>
        Boy,
        /// <summary>
        /// Девочка
        /// </summary>
        Girl
    }

    /// <summary>
    /// Дополнительная информация 
    /// </summary>
    public class AdditionalInformation
    {
        /// <summary>
        /// Родословная
        /// </summary>
        public string Pedigree { get; set; }

        /// <summary>
        /// Вакцинация
        /// </summary>
        public Vaccination Vaccination { get; set; }

        /// <summary>
        /// Другая информация
        /// </summary>
        public string Other { get; set; }
    }

    /// <summary>
    /// Вакцинация
    /// </summary>
    public class Vaccination
    {
        /// <summary>
        /// Дата прививки
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public DateTime Name { get; set; }
    }

    /// <summary>
    /// Достижение на выставке
    /// </summary>
    public class Achievement
    {
        /// <summary>
        /// Дата выставки
        /// </summary>
        public DateTime CompetitionDate { get; set; }

        /// <summary>
        /// Место проведения
        /// </summary>
        public string Venue { get; set; }

        /// <summary>
        /// Титул 
        /// </summary>
        public string Title { get; set; }
    } 
}
