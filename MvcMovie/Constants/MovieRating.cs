using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Constants
{
    public enum MovieRating
    {
        [Description("일반적인 셩인영화")]
        [Display(Name ="R")]
        R,
        [Description("전체관람가")]
        [Display(Name = "G")]
        G,
        [Description("부모 지도하에 전체관람가")]
        [Display(Name = "PG")]
        PG,
        [Description("13세 이상 부모지도하에 관람가")]
        [Display(Name = "PG-13")]
        PG13,
        [Description("19금")]
        [Display(Name = "NC-17")]
        NC17
    }
}
