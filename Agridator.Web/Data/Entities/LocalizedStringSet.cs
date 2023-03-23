using System.ComponentModel.DataAnnotations;
using System.Globalization;

#nullable enable
namespace Agridator.Web.Data.Entities
{
    /// <summary>
    /// Localized string set to enable multilanguage fields in the
    /// database
    /// </summary>
    public class LocalizedStringSet
    {
        [MaxLength(8000)]
        public string? Fr { get; set; } = string.Empty;

        [MaxLength(8000)]
        public string? De { get; set; } = string.Empty;

        [MaxLength(8000)]
        public string? It { get; set; } = string.Empty;

        public string Value => GetStringBasedOnCurrentCulture();

        public override string ToString() => Value;

        public string GetStringBasedOnLanguageString(string language) => language switch
        {
            "fr" => Fr ?? string.Empty,
            "it" => It ?? string.Empty,
            _ => De ?? string.Empty
        };

        private string GetStringBasedOnCurrentCulture() => GetStringBasedOnLanguageString(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);

        public void Append(LocalizedStringSet localizedStringSet)
        {
            if (localizedStringSet is null)
            {
                throw new ArgumentNullException(nameof(localizedStringSet));
            }

            De += string.IsNullOrWhiteSpace(De) ? localizedStringSet.De : "\r\n" + localizedStringSet.De;
            Fr += string.IsNullOrWhiteSpace(Fr) ? localizedStringSet.Fr : "\r\n" + localizedStringSet.Fr;
            It += string.IsNullOrWhiteSpace(It) ? localizedStringSet.It : "\r\n" + localizedStringSet.It;
        }
    }
}
