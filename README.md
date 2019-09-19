# answer-helper “学习强国《挑战答题》”辅助工具

## 使用

### 环境

Visual Studio 2015 Professional
PostgreSQL 10

### 投屏工具

只要能将手机屏幕投影到电脑即可。这里使用了AirDroid（无需root）。

### 百度AI客户端

登录百度AI开放平台，进入控制台，新建文字识别应用。

### 题库

#### 题库文件

题库文件可以使用网上现成的，也可以自己收集，要求是纯文本，并且每一行是一个题目（含答案）。
项目中提供了一个已收集好的题库文件[questionSource.txt](https://github.com/bingoyao/answer-helper/blob/master/questionSource.txt)

#### 配置PostGre数据库

**检索题目时使用了模糊查询，只能使用Postgre数据库**
新建数据库 answer_helper
新建表 qiangguo

```plsql
CREATE TABLE public.qiangguo
(
    question text COLLATE pg_catalog."default" NOT NULL,
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    "enrollTime" timestamp with time zone NOT NULL,
    CONSTRAINT qiangguo_pkey PRIMARY KEY (id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

-- Index: question_idx

-- DROP INDEX public.question_idx;

CREATE INDEX question_idx
    ON public.qiangguo USING gist
    (question COLLATE pg_catalog."default" gist_trgm_ops)
    TABLESPACE pg_default;
```

#### 导入题库到数据库

运行项目->点击->应用管理->文件导入->选择题库文件导入

### 应用设置

找到[AnswerHelper.exe.config](https://github.com/bingoyao/answer-helper/blob/master/AnswerHelper/bin/Debug/AnswerHelper.exe.config)文件，将userSettings中各项根据自己实际配置改写。

### 辅助答题

#### 设置投屏区域

将手机投屏到电脑后，进入挑战答题，点击“设置截图区域”，选中题目区域后双击左键选中区域确定，截图时单击右键取消。
**设置好截图区域后不要移动投屏软件位置。**

#### 题库辅助答题

题目出现后点击题库辅助答题可在题库中检索相似题目，较新的题目题库中可能检索不到。

#### 网络辅助答题

题目出现后点击浏览器辅助答题可使用内置浏览器从网络检索题目，检索到结果后可点击左右箭头查看其它结果。浏览结果时，可以屏蔽经常出现而又没有正确答案的网站。
**从网络检索题目将耗费较多时间，而且也有检索不到的风险。**

#### 自动搜索

题目出现后点击自动搜索将先使用题库搜索结果，未找到结果时自动使用网络搜索。

![demo]("./demo.gif")
