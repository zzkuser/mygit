using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore01
{
    /// <summary>
    /// 2021-01-19
    /// z
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args)//��������ķ���������һ��IWebHostBuilder����
                .Build()//�����淵�ص�IWebHostBuilder���󴴽�һ��IWebHost
                .Run();//�������洴����IWebHost����Ӷ��������ǵ�WebӦ�ó���,���仰˵��������һ��һֱ���м���http���������
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)//ʹ��Ĭ�ϵ�������Ϣ����ʼ��һ���µ�IWebHostBuilderʵ��
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();// ΪWeb Hostָ����Startup��
                });
    }
}
