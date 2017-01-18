select * from Country c with (nolock)
inner join [state] s with (nolock) on c.CountryID = s.CountryID

select * from Country c with (nolock)
left join [state] s with (nolock) on c.CountryID = s.CountryID

select * from Country c with (nolock)
right join [state] s with (nolock) on c.CountryID = s.CountryID

