using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//using BookWorldSelfhost;

namespace BookWorldAdmin
{
    class ServiceClient
    {
        internal async static Task<List<clsBook>> GetBookNamesAsync(string Genre)
        {
            Console.WriteLine("Front {0}", Genre);
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsBook>>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/book/GetBookListByGenreId?Genre=" + Genre));
        }

        internal async static Task<List<clsGenre>> GetGenreNamesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsGenre>>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/book/GetGenreList/"));
        }

        internal async static Task<string> GetGenreIdAsync(string Genre)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<string>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/book/GetGenreIdByName?Genre=" + Genre));
        }

        internal async static Task<string> GetBookNameAsync(string BookName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<string>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/book/GetBookNameByName?BookName=" + BookName));
        }

        internal async static Task<string> GetBookIdAsync(string BookName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<string>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/book/GetBookIdByName?BookName=" + BookName));
        }

        internal async static Task<clsBook> GetBooksDetailsAsync(string prBookId)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsBook>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/book/GetBookDetailsById?BookId=" + prBookId));
        }

        //internal async static Task<string> GetGenreNameAsync(string GenreId)
        //{
        //    using (HttpClient lcHttpClient = new HttpClient())
        //        return JsonConvert.DeserializeObject<string>
        //            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/book/GetGenreNameById?GenreId=" + GenreId));
        //}

        internal async static Task<string> GetGenreNameAsync(string GenreId)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<string>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/book/GetGenreNameById?GenreId=" + GenreId));
        }

        internal async static Task<string> InsertBookAsync(clsBook prBook)
        {
            return await InsertOrUpdateAsync(prBook, "http://localhost:60064/api/book/PostBook", "POST");
        }

        internal async static Task<string> UpdateBookAsync(clsBook prBook)
        {
            return await InsertOrUpdateAsync(prBook, "http://localhost:60064/api/book/UpdateBook", "POST");
        }

        internal async static Task<string> DeleteBookAsync(string prBookId)
        {
            return await InsertOrUpdateAsync(prBookId, "http://localhost:60064/api/book/DeleteBook", "DELETE");
        }


        //internal async static Task<string> DeleteBookAsync(string prBookId)
        //{
        //    using (HttpClient lcHttpClient = new HttpClient())
        //        return JsonConvert.DeserializeObject<string>
        //            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/book/DeleteBook?BookId=" + prBookId));
        //}

        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content = new StringContent(JsonConvert.SerializeObject(prItem), Encoding.Default, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }
    }
}
