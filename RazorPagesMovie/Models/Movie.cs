using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    //ここにはデータベース情報を定義する
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        //データベースの通貨とpriceが正しくマッピングするよう以下に注釈
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        //ムービーモデルへの評価プロパティ追加
        public string Rating { get; set; }
    }
}
