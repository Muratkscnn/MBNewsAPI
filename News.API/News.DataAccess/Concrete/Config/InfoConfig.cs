﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using News.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DataAccess.Concreate.Config
{
    public class InfoConfig : IEntityTypeConfiguration<Info>
    {
        public void Configure(EntityTypeBuilder<Info> builder)
        {
            builder.HasData(
                new Info { InfoId = 1, CategoryId = 5, Content = "İtalya'da açıklarındaki feribot yangınında kaybolan TIR şoförü Mehmet Çakır'dan (42) 130 gündür haber alınamadı. Aydınlı olan Çakır'ın eniştesi Davut Gür (52), Hala bir ses yok.Ablası, annesi ve babası merak içinde.En azından öldüyse cenazesini memleketine defnetmek istiyoruz.Artık akıbetini öğrenmek istiyoruz dedi", NewsName = "İtalya da kaybolan Türk şoförden haber alınamıyor", ImageUrl = "https://im.haberturk.com/2022/06/27/3473052_5f7955d6a10f726bfac7565d7f8ed46c_640x640.jpg", },
                new Info { InfoId = 2, CategoryId = 4, Content = "Ürdün'ün Akabe kentinde tankerin patlaması sonucu sızan zehirli gazdan 10 kişi öldü, 250’den fazla kişi yaralandı", NewsName = "Son dakika haberi Ürdün'de tanker patladı: 10 kişi öldü", ImageUrl = "https://im.haberturk.com/2022/06/27/ver1656350244/3473039_810x458.jpg", },
                new Info { InfoId = 3, CategoryId = 4, Content = "NATO Genel Sekreteri Jens Stoltenberg, Madrid´de yapılacak NATO Liderler Zirvesi öncesi basın mensuplarının sorularını yanıtladı. Stoltenberg, İsveç, Finlandiya ve Türkiye arasında yapılacak toplantıya ilişkin Amaç elbette Finlandiya ve İsveç konusunda ilerleme kaydetmek.Herhangi bir söz vermeyeceğim ama sizi temin ederim ki ilerlemeyi sağlamak için aktif olarak çalışıyoruz dedi.", NewsName = "Stoltenberg´den Türkiye açıklaması: Amacımız ilerleme kaydetmek", ImageUrl = "https://im.haberturk.com/2022/06/27/ver1656345623/3472996_810x458.jpg", },
                new Info { InfoId = 4, CategoryId = 2, Content = "Son dakika haberi CHP'de Aykut Erdoğdu ve Tuba Torun istifa etti", NewsName = "CHP İstanbul Milletvekili Aykut Erdoğdu ve Yüksek Disiplin Kurulu üyesi Tuba Torun Erdoğdu partiden istifa etti. Erdoğdu ve Torun'un CHP'nin kendileri üzerinden yıpratılmaması amacıyla bu kararı aldıklarını belirtildi", ImageUrl = "https://im.haberturk.com/2022/06/29/ver1656507938/3473528_810x458.jpg", },
                new Info { InfoId = 5, CategoryId = 3, Content = "Son dakika transfer haberi... Galatasaray, Joao Pedro ile prensipte anlaştı", NewsName = "Galatasaray, İtalya Serie A ekiplerinden Cagliari'de forma giyen Joao Pedro'yu kadrosuna katmak üzere...", ImageUrl = "https://im.haberturk.com/2022/06/29/3473478_be511c925b75dc7ecc2a46d64446ba17_640x640.jpg", },
                new Info { InfoId = 6, CategoryId = 3, Content = "Son dakika Fenerbahçe haberleri... Süper Lig ekibi Fenerbahçe'nin deneyimli futbolcusu Enner Valencia, geleceğine ilişkin açıklamalarda bulundu. Valencia, 'Menajerim gelecek hafta Türkiye'ye gelecek, Fenerbahçe ile geleceğim hakkında konuşacak dedi!", NewsName = "Son dakika Fenerbahçe haberleri... Valencia'dan flaş açıklama: Menajerim gelecek!", ImageUrl = "https://im.haberturk.com/2022/06/29/ver1656493754/3473479_810x458.jpg", },
                new Info { InfoId = 7, CategoryId = 3, Content = "Spor Toto Süper Lig'den düşen Yeni Malatyaspor Kulübü, olağanüstü seçimli genel kurul kararı aldı", NewsName = "Yeni Malatyaspor Kulübü olağanüstü genel kurul kararı aldı", ImageUrl = "https://im.haberturk.com/2022/06/29/ver1656511157/3473583_810x458.jpg", },
                new Info { InfoId = 8, CategoryId = 3, Content = "Anadolu Efes, Adrien Moerman ile yolların ayrıldığını açıkladı", NewsName = "Anadolu Efes'te ayrılık", ImageUrl = "https://im.haberturk.com/2022/06/29/ver1656492854/3473474_810x458.jpg", },
                new Info { InfoId = 15, CategoryId = 3, Content = "Aytemiz Alanyaspor, genç oyuncu Mert Yusuf Torlak'ı 5 yıllığına kadrosuna kattı", NewsName = "Mert Yusuf, 5 yıllığına Alanyaspor’da", ImageUrl = "https://im.haberturk.com/2022/06/28/ver1656426239/3473301_810x458.jpg", },
                new Info { InfoId = 9, CategoryId = 3, Content = "Son dakika haberine göre; Fenerbahçe, Fatih Karagümrük'ten Emre Mor'un transferi için prensip anlaşmasına varıldığını açıkladı! Sarı-lacivertli kulübün paylaşımında Kulübümüz, Emre Mor transferi için Fatih Karagümrük Kulübü ve oyuncunun kendisi ile prensip anlaşmasına varmıştır ifadelerine yer verildi", NewsName = "Son dakika: Fenerbahçe Emre Mor transferini açıkladı!", ImageUrl = "https://im.haberturk.com/2022/06/29/ver1656487958/3473369_810x458.jpg", },
                new Info { InfoId = 10, CategoryId = 3, Content = "Galatasaray Nef, ABDli oyuncu Raymar Morgan'ı kadrosuna kattı. Raymar Morgan, Türkiye'de daha önce Pınar Karşıyaka ve TOFAŞ'ta forma giymişti", NewsName = "Raymar Morgan, Galatasaray Nef'e transfer oldu", ImageUrl = "https://im.haberturk.com/2022/06/28/ver1656435892/3473333_810x458.jpg", },
                new Info { InfoId = 11, CategoryId = 3, Content = "Beşiktaş, yeni sezon hazırlıklarına bu akşam yaptığı çalışmayla devam etti. Valerien Ismael yönetiminde yapılan antrenman, yaklaşık 1.5 saat sürdü. Siyah-beyazlı ekip, yeni sezon hazırlıklarına, yarın saat 10.30 ve 16.00´da yapacağı çalışmalarla devam edecek", NewsName = "Beşiktaş'ta yeni sezon hazırlıkları sürdü", ImageUrl = "https://im.haberturk.com/2022/06/28/ver1656440926/3473346_810x458.jpg", },
                new Info { InfoId = 12, CategoryId = 3, Content = "Aytemiz Alanyaspor, genç oyuncu Mert Yusuf Torlak'ı 5 yıllığına kadrosuna kattı", NewsName = "Mert Yusuf, 5 yıllığına Alanyaspor’da", ImageUrl = "https://im.haberturk.com/2022/06/28/ver1656426239/3473301_810x458.jpg", },
                new Info { InfoId = 13, CategoryId = 3, Content = "Galatasaray'da yeni sezon hazırlıklarına başlayan futbolcular, sağlık kontrolünden geçti", NewsName = "Galatasaraylı futbolcular sağlık kontrolünden geçti", ImageUrl = "https://im.haberturk.com/2022/06/28/ver1656418200/3473264_810x458.jpg", },
                new Info { InfoId = 14, CategoryId = 3, Content = "Son dakika Fenerbahçe transfer haberleri... Fenerbahçe golcü transferinde önceliğini Dominikli forvete verdi. Sarı-Lacivertliler, Real Madrid’in 6 milyon Euro'luk maliyeti nedeniyle kadroda düşünmediği 28 yaşındaki forvetle masaya oturdu. Olumlu geçen görüşmelerin kısa sürede netleşmesi bekleniyor. İşte son dakika haberinin detayları", NewsName = "Son dakika Fenerbahçe transfer haberleri - Hedefteki isim Mariano Diaz!", ImageUrl = "https://im.haberturk.com/2022/06/28/3473182_0fe84dd1097b9557ee2b9f146c3a560b_640x640.jpg", }
            );
        }
    }
}
