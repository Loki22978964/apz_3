using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Enum
{
    public enum DataFormat
    {
        // Документи
        Pdf,
        Doc,
        Docx,
        Txt,
        Rtf,
        Xls,
        Xlsx,
        Csv,
        Ppt,
        Pptx,

        // Зображення
        Jpg,
        Jpeg,
        Png,
        Gif,
        Bmp,
        Svg,
        Webp,

        // Відео
        Mp4,
        Avi,
        Mov,
        Mkv,
        Webm,
        Flv,

        // Аудіо
        Mp3,
        Wav,
        Flac,
        Aac,
        Ogg,

        // Архіви
        Zip,
        Rar,
        SevenZip,
        Tar,
        Gz,

        // Дані / інше
        Json,
        Xml,
        Html,
        Css,
        Js,
        Exe,
        Dll
    }
}
