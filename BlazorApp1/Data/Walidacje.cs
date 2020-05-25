using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class Walidacje
    {
        [Range(0, 4, ErrorMessage = "Wybierz")]
        public int wyksztalcenie { get; set; }

        [Range(0, 4, ErrorMessage = "Wybierz")]
        public int zdrowie { get; set; }

        [Range(0, 4, ErrorMessage = "Wybierz")]
        public int pomoc { get; set; }

        [Range(0, 4, ErrorMessage = "Wybierz")]
        public int samotnosc { get; set; }

        [Range(0, 4, ErrorMessage = "Wybierz")]
        public int bezpieczenstwo { get; set; }

        [Range(0, 4, ErrorMessage = "Wybierz")]
        public int technologia { get; set; }

        [Range(0, 4, ErrorMessage = "Wybierz")]
        public int internet { get; set; }

        [Range(0, 4, ErrorMessage = "Wybierz")]
        public int internet2 { get; set; }

        [Range(0, 4, ErrorMessage = "Wybierz")]
        public int monitoring { get; set; }

        [Range(0, 4, ErrorMessage = "Wybierz")]
        public int monitoring1 { get; set; }

        [Range(0, 4, ErrorMessage = "Wybierz")]
        public int wizyjny { get; set; }

        [Range(0, 4, ErrorMessage = "Wybierz")]
        public int czujnik { get; set; }

        [Range(0, 4, ErrorMessage = "Wybierz")]
        public int robot { get; set; }

        [Range(0, 1, ErrorMessage = "Wybierz")]
        public int choraosoba { get; set; }

        [Range(0, 1, ErrorMessage = "Wybierz")]
        public int mieszkaniezseniorem { get; set; }

        [Range(0, 4, ErrorMessage = "Wybierz")]
        public int opieka { get; set; }

        [Range(0, 5, ErrorMessage = "Wybierz")]
        public int mieszkanieZaznacz { get; set; }

        [Required]
        public bool check { get; set; }
    }
}
