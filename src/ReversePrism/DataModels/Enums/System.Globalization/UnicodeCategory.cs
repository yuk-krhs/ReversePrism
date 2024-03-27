using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum UnicodeCategory
    {
        UppercaseLetter,
        LowercaseLetter,
        TitlecaseLetter,
        ModifierLetter,
        OtherLetter,
        NonSpacingMark,
        SpacingCombiningMark,
        EnclosingMark,
        DecimalDigitNumber,
        LetterNumber,
        OtherNumber,
        SpaceSeparator,
        LineSeparator,
        ParagraphSeparator,
        Control,
        Format,
        Surrogate,
        PrivateUse,
        ConnectorPunctuation,
        DashPunctuation,
        OpenPunctuation,
        ClosePunctuation,
        InitialQuotePunctuation,
        FinalQuotePunctuation,
        OtherPunctuation,
        MathSymbol,
        CurrencySymbol,
        ModifierSymbol,
        OtherSymbol,
        OtherNotAssigned,
    }
}
