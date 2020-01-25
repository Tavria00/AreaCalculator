declare @articles table(id int, title varchar(225))
declare @tags table(id int, title varchar(225))
declare @articleToTag table(articleId int, tagId int)

select a.title, t.title from @articles a 
left join @articleToTag att on att.articleId = a.id
left join @tags t on att.tagId = t.id