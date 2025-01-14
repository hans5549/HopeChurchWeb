using HopeChurchWeb.Models;

namespace HopeChurchWeb.Data;

public class FakeData
{
    public List<UserMain> GetUserList()
    {
        return
        [
            new UserMain
            {
                Account = "黃芃銘", Email = "xiaoming.zhang@example.com", Password = "AAA", IsActive = true
            },
            new UserMain
            {
                Account = "張小明", Email = "xiaoming.zhang@example.com", Password = "hashed_password_001", IsActive = true
            },
            new UserMain
                { Account = "李美琪", Email = "meiqi.li@example.com", Password = "hashed_password_002", IsActive = true },
            new UserMain
            {
                Account = "王大華", Email = "dahua.wang@example.com", Password = "hashed_password_003", IsActive = true
            },
            new UserMain
            {
                Account = "陳佳佳", Email = "jiajia.chen@example.com", Password = "hashed_password_004", IsActive = false
            },
            new UserMain
            {
                Account = "林志偉", Email = "zhiwei.lin@example.com", Password = "hashed_password_005", IsActive = true
            },
            new UserMain
            {
                Account = "黃雅芳", Email = "yafang.huang@example.com", Password = "hashed_password_006", IsActive = true
            },
            new UserMain
            {
                Account = "劉建國", Email = "jianguo.liu@example.com", Password = "hashed_password_007", IsActive = true
            },
            new UserMain
            {
                Account = "吳淑芬", Email = "shufen.wu@example.com", Password = "hashed_password_008", IsActive = false
            },
            new UserMain
            {
                Account = "蔡明宏", Email = "minghong.tsai@example.com", Password = "hashed_password_009", IsActive = true
            },
            new UserMain
            {
                Account = "楊智敏", Email = "zhimin.yang@example.com", Password = "hashed_password_010", IsActive = true
            },
            new UserMain
            {
                Account = "周俊傑", Email = "junjie.zhou@example.com", Password = "hashed_password_011", IsActive = true
            },
            new UserMain
                { Account = "許雅婷", Email = "yating.xu@example.com", Password = "hashed_password_012", IsActive = true },
            new UserMain
            {
                Account = "鄭家豪", Email = "jiahao.zheng@example.com", Password = "hashed_password_013", IsActive = false
            },
            new UserMain
            {
                Account = "謝佳玲", Email = "jialing.xie@example.com", Password = "hashed_password_014", IsActive = true
            },
            new UserMain
            {
                Account = "宋志成", Email = "zhicheng.song@example.com", Password = "hashed_password_015", IsActive = true
            },
            new UserMain
                { Account = "賴怡君", Email = "yijun.lai@example.com", Password = "hashed_password_016", IsActive = true },
            new UserMain
            {
                Account = "徐志明", Email = "zhiming.xu@example.com", Password = "hashed_password_017", IsActive = false
            },
            new UserMain
            {
                Account = "葉俊宏", Email = "junhong.ye@example.com", Password = "hashed_password_018", IsActive = true
            },
            new UserMain
            {
                Account = "莊雅雯", Email = "yawen.zhuang@example.com", Password = "hashed_password_019", IsActive = true
            },
            new UserMain
            {
                Account = "潘建志", Email = "jianzhi.pan@example.com", Password = "hashed_password_020", IsActive = true
            },
            new UserMain
            {
                Account = "趙美玲", Email = "meiling.zhao@example.com", Password = "hashed_password_021", IsActive = true
            },
            new UserMain
            {
                Account = "蘇志豪", Email = "zhihao.su@example.com", Password = "hashed_password_022", IsActive = false
            },
            new UserMain
            {
                Account = "余佳蓉", Email = "jiarong.yu@example.com", Password = "hashed_password_023", IsActive = true
            },
            new UserMain
            {
                Account = "范志強", Email = "zhiqiang.fan@example.com", Password = "hashed_password_024", IsActive = true
            },
            new UserMain
            {
                Account = "朱雅芳", Email = "yafang.zhu@example.com", Password = "hashed_password_025", IsActive = true
            },
            new UserMain
            {
                Account = "唐建華", Email = "jianhua.tang@example.com", Password = "hashed_password_026", IsActive = false
            },
            new UserMain
            {
                Account = "曾淑英", Email = "shuying.zeng@example.com", Password = "hashed_password_027", IsActive = true
            },
            new UserMain
            {
                Account = "江志偉", Email = "zhiwei.jiang@example.com", Password = "hashed_password_028", IsActive = true
            },
            new UserMain
                { Account = "盧佳琪", Email = "jiaqi.lu@example.com", Password = "hashed_password_029", IsActive = true },
            new UserMain
            {
                Account = "梁家豪", Email = "jiahao.liang@example.com", Password = "hashed_password_030", IsActive = false
            },
            new UserMain
            {
                Account = "顏雅芳", Email = "yafang.yan@example.com", Password = "hashed_password_031", IsActive = true
            },
            new UserMain
            {
                Account = "馬志明", Email = "zhiming.ma@example.com", Password = "hashed_password_032", IsActive = true
            },
            new UserMain
            {
                Account = "尹佳玲", Email = "jialing.yin@example.com", Password = "hashed_password_033", IsActive = true
            },
            new UserMain
            {
                Account = "方建國", Email = "jianguo.fang@example.com", Password = "hashed_password_034", IsActive = false
            },
            new UserMain
                { Account = "何淑芬", Email = "shufen.he@example.com", Password = "hashed_password_035", IsActive = true },
            new UserMain
            {
                Account = "邱明宏", Email = "minghong.qiu@example.com", Password = "hashed_password_036", IsActive = true
            },
            new UserMain
            {
                Account = "湯智敏", Email = "zhimin.tang@example.com", Password = "hashed_password_037", IsActive = true
            },
            new UserMain
            {
                Account = "秦俊傑", Email = "junjie.qin@example.com", Password = "hashed_password_038", IsActive = false
            },
            new UserMain
            {
                Account = "任雅婷", Email = "yating.ren@example.com", Password = "hashed_password_039", IsActive = true
            },
            new UserMain
            {
                Account = "田家豪", Email = "jiahao.tian@example.com", Password = "hashed_password_040", IsActive = true
            },
            new UserMain
            {
                Account = "袁佳玲", Email = "jialing.yuan@example.com", Password = "hashed_password_041", IsActive = true
            },
            new UserMain
            {
                Account = "駱志成", Email = "zhicheng.luo@example.com", Password = "hashed_password_042", IsActive = false
            },
            new UserMain
                { Account = "巫怡君", Email = "yijun.wu@example.com", Password = "hashed_password_043", IsActive = true },
            new UserMain
            {
                Account = "彭志明", Email = "zhiming.peng@example.com", Password = "hashed_password_044", IsActive = true
            },
            new UserMain
            {
                Account = "傅俊宏", Email = "junhong.fu@example.com", Password = "hashed_password_045", IsActive = true
            },
            new UserMain
            {
                Account = "費雅雯", Email = "yawen.fei@example.com", Password = "hashed_password_046", IsActive = false
            },
            new UserMain
            {
                Account = "白建志", Email = "jianzhi.bai@example.com", Password = "hashed_password_047", IsActive = true
            },
            new UserMain
            {
                Account = "史美玲", Email = "meiling.shi@example.com", Password = "hashed_password_048", IsActive = true
            },
            new UserMain
                { Account = "齊志豪", Email = "zhihao.qi@example.com", Password = "hashed_password_049", IsActive = true },
            new UserMain
            {
                Account = "康佳蓉", Email = "jiarong.kang@example.com", Password = "hashed_password_050", IsActive = false
            }
        ];
    }

    public List<LinksMain> GetLinksList()
    {
        return
        [
            new LinksMain { Id = 1, Title = "Google搜尋", Description = "全球最大的搜尋引擎", Url = "https://www.google.com" },
            new LinksMain { Id = 2, Title = "YouTube", Description = "影音分享平台", Url = "https://www.youtube.com" },
            new LinksMain { Id = 3, Title = "Facebook", Description = "社群媒體平台", Url = "https://www.facebook.com" },
            new LinksMain { Id = 4, Title = "LinkedIn", Description = "專業人士社交網路", Url = "https://www.linkedin.com" },
            new LinksMain { Id = 5, Title = "GitHub", Description = "程式碼託管平台", Url = "https://github.com" },
            new LinksMain { Id = 6, Title = "Stack Overflow", Description = "程式開發問答網站", Url = "https://stackoverflow.com" },
            new LinksMain { Id = 7, Title = "Microsoft", Description = "微軟官方網站", Url = "https://www.microsoft.com" },
            new LinksMain { Id = 8, Title = "Apple", Description = "蘋果公司官方網站", Url = "https://www.apple.com" },
            new LinksMain { Id = 9, Title = "Amazon", Description = "全球最大電商平台", Url = "https://www.amazon.com" },
            new LinksMain { Id = 10, Title = "Netflix", Description = "串流影音服務", Url = "https://www.netflix.com" },
            new LinksMain { Id = 11, Title = "Twitter", Description = "即時社交媒體平台", Url = "https://twitter.com" },
            new LinksMain { Id = 12, Title = "Instagram", Description = "圖片分享社群平台", Url = "https://www.instagram.com" },
            new LinksMain { Id = 13, Title = "Reddit", Description = "社群討論平台", Url = "https://www.reddit.com" },
            new LinksMain { Id = 14, Title = "Wikipedia", Description = "線上百科全書", Url = "https://www.wikipedia.org" },
            new LinksMain { Id = 15, Title = "Medium", Description = "部落格發布平台", Url = "https://medium.com" },
            new LinksMain { Id = 16, Title = "Spotify", Description = "音樂串流服務", Url = "https://www.spotify.com" },
            new LinksMain { Id = 17, Title = "Docker Hub", Description = "容器映像檔庫", Url = "https://hub.docker.com" },
            new LinksMain { Id = 18, Title = "Azure", Description = "微軟雲端服務", Url = "https://azure.microsoft.com" },
            new LinksMain { Id = 19, Title = "AWS", Description = "亞馬遜雲端服務", Url = "https://aws.amazon.com" },
            new LinksMain
                { Id = 20, Title = "Google Cloud", Description = "Google雲端服務", Url = "https://cloud.google.com" },
            new LinksMain { Id = 21, Title = "NPM", Description = "Node.js套件管理器", Url = "https://www.npmjs.com" },
            new LinksMain { Id = 22, Title = "NuGet", Description = ".NET套件管理平台", Url = "https://www.nuget.org" },
            new LinksMain { Id = 23, Title = "PyPI", Description = "Python套件索引", Url = "https://pypi.org" },
            new LinksMain { Id = 24, Title = "CodePen", Description = "線上程式碼編輯器", Url = "https://codepen.io" },
            new LinksMain { Id = 25, Title = "JSFiddle", Description = "線上前端開發環境", Url = "https://jsfiddle.net" },
            new LinksMain { Id = 26, Title = "LeetCode", Description = "程式競賽平台", Url = "https://leetcode.com" },
            new LinksMain { Id = 27, Title = "W3Schools", Description = "網頁開發學習資源", Url = "https://www.w3schools.com" },
            new LinksMain
                { Id = 28, Title = "MDN", Description = "Mozilla開發者文件", Url = "https://developer.mozilla.org" },
            new LinksMain { Id = 29, Title = "Bootstrap", Description = "前端框架官網", Url = "https://getbootstrap.com" },
            new LinksMain { Id = 30, Title = "jQuery", Description = "JavaScript函式庫", Url = "https://jquery.com" }
        ];
    }
}