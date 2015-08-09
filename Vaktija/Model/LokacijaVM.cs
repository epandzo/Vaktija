using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaktija.Model
{
    public class LokacijaVM
    {
        public static String Grad {
            get {
                var applicationData = Windows.Storage.ApplicationData.Current;
                var localSettings = applicationData.LocalSettings;
                var grad = localSettings.Values["Grad"] as string;
                if (string.IsNullOrWhiteSpace(grad)) grad = "SARAJEVO";
                return grad;
            }
            set {
                var applicationData = Windows.Storage.ApplicationData.Current;
                var localSettings = applicationData.LocalSettings;
                localSettings.Values["Grad"] = value;
            }
        }

        public static string[] Opstine = new string[] {
            "BANOVIĆI","BANJA LUKA","BIHAĆ","BIJELJINA","BILEĆA","BOS.BROD","BOS.DUBICA","BOS.GRADIŠKA","BOS.GRAHOVO","BOS.KRUPA","BOS.NOVI","BOS.PETROVAC","BOS.ŠAMAC","BRATUNAC","BRČKO",
            "BREZA","BUGOJNO","BUSOVAČA","BUŽIM","CAZIN","ČAJNIČE","ČAPLJINA","ČELIĆ","ČELINAC","ČITLUK","DERVENTA","DOBOJ","DONJI VAKUF","DRVAR","FOČA","FOJNICA","GACKO","GLAMOČ","GORAŽDE",
            "GORNJI VAKUF","GRAČANICA","GRADAČAC","GRUDE","HADŽIĆI","HAN PIJESAK","HLIVNO","ILIJAŠ","JABLANICA","JAJCE","KAKANJ","KALESIJA","KALINOVIK","KISELJAK","KLADANJ","KLJUČ","KONJIC",
            "KOTOR VAROŠ","KREŠEVO","KUPRES","LAKTAŠI","LOPARE","LUKAVAC","LJUBINJE","LJUBUŠKI","MAGLAJ","MODRIČA","MOSTAR","MRKONJIĆ GRAD","NEUM","NEVESINJE","NOVI TRAVNIK","ODŽAK","OLOVO",
            "ORAŠJE","PALE","POSUŠJE","PRIJEDOR","PRNJAVOR","PROZOR","ROGATICA","RUDO","SANSKI MOST","SARAJEVO","SKENDER VAKUF","SOKOLAC","SRBAC","SREBRENICA","SREBRENIK","STOLAC","ŠEKOVIĆI","ŠIPOVO",
            "ŠIROKI BRIJEG","TESLIĆ","TEŠANJ","TOMISLAVGRAD","TRAVNIK","TREBINJE","TRNOVO","TUZLA","UGLJEVIK","VAREŠ","V.KLADUŠA","VISOKO","VIŠEGRAD","VITEZ","VLASENICA","ZAVIDOVIĆI","ZENICA",
            "ZVORNIK","ŽEPA","ŽEPČE","ŽIVINICE"
        };
    }
}
