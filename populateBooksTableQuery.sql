insert into Books(Title, AuthorId, ISBN)
select 'How To Read a Book', AuthorId,'1234567891234' from Authors where Name = 'Douglas Boyle'
union all
select 'How To Book', AuthorId,'1234567891256' from Authors where Name = 'Hizkia Susanto'
union all
select 'This is a Book', AuthorId,'001' from Authors where Name = 'Douglas Boyle'
union all
select 'dwef jbaw', AuthorId,'1234567688' from Authors where Name = 'Emilies Stone'
union all
select 'Is this a book?', AuthorId,'1234567891888' from Authors where Name = 'Michael Collingwood'
union all
select 'How To Read a Book', AuthorId,'1234567891235' from Authors where Name = 'Hizkia Susanto'
union all
select 'Harry Poster Boy', AuthorId,'Swag' from Authors where Name = 'Ted While';