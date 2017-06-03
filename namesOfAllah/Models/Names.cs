﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace namesOfAllah.Models
{
    public class Names
    {
        public Dictionary<string, Name> ListOfNames = null;
        public Names()
        {
            ListOfNames = new Dictionary<string, Name>();

            ListOfNames["Аллах"] = new Name() { One_Name = "Аллах", Description = "Аллах — Тот, Кто заслуживает обожествления и поклонения. Все творения обязаны обожествлять Его и поклоняться Ему, потому что Он обладает божественными качествами, то есть качествами совершенства." };

            ListOfNames["Господь"] = new Name() { One_Name = "Господь", Description = "Всевышний сказал: «Скажи: “Неужели я стану искать другого господа помимо Аллаха, в то время как Он — Господь всякой вещи ?”» (сура 6 «Скот», аят 164). Господь — Тот, Кто заботится обо всех рабах, управляя их судьбами и одаряя их всевозможными благами.Особую заботу Аллах проявляет о Своих избранниках, приводя в порядок их сердца, души и нравственный облик.Поэтому в своих молитвах они часто называют Его этим славным именем, надеясь на Его особую заботу." };

            ListOfNames["Первый, Последний, Высочайший, Ближайший"] = new Name() { One_Name = "Первый, Последний, Высочайший, Ближайший", Description = "Всевышний Аллах сказал: Он — Первый и Послед­ний, Высочайший и Бли­жайший. Сура 57 «Железо»,аят 3. Эти четыре благословенных имени были ясно и всесторонне разъяснены Пророком(да благословит его Аллах и приветствует) в одной из молитв: «О Аллах, Ты — Первый, и нет ничего прежде Тебя, и Ты — Последний, и нет ничего после Тебя. Ты — Высочайший, и нет никого выше Тебя, и Ты — Ближайший, и нет никого ближе Тебя» [Муслим, т. 4, с. 2084]. Он указал на величественные значения каждого имени, отвергнув всё, что противоречит и противопоставляется им.Задумайся же над этими славными значениями, указывающими на то, что только Великий Господь обладает абсолютным совершенством и полностью объемлет время (первые два имени) и пространство (последниедва имени). Первый означает, что всё остальное некогда не существовало, а потом возникло. Это обязывает рабов замечать милость Господа во всех духовных и материальных благах, ибо только Он создаёт причины для их обретения. Последний означает, что Аллах — цель, к которой стремятся творения, обоготворяя Его, желая приблизиться к Нему и испытывая страх перед Ним. Высочайший указывает на величие божественных качеств и на то, что перед Его величием меркнет всё сущее и любые качества, какими бы славными они ни были. Ближайший указывает на то, что Ему ведомы любые тайны, сокровенные мысли и намерения. Он доподлинно знает обо всём в мельчайших подробностях. Это имя также свидетельствует о совершенстве Его близости к рабам. Имена Высочайший и Ближайший не противоречат друг другу, ибо ничьи качества не подобны качествам Аллаха." };

            ListOfNames["Возвышенный, Всевышний, Превознёсшийся"] = new Name() { One_Name = "Возвышенный, Всевышний, Превознёсшийся", Description = "Всевышний Аллах сказал: Не тяготит Его оберегание их. Он — Возвышенный, Великий. Сура 2 «Корова», аят 255. Славь имя Господа твоего Всевышнего. Сура 87 «Всевышний», аят 1. Он — Ведающий сокро­венное и явное, Большой, Превознёсшийся. Сура 13 «Гром», аят 9. Эти имена объединяют все проявления возвышенности, присущие Аллаху.Его высокое положение объясняется вознесением на Трон, и Он находится над рабами Своей божественной сущностью. Его высокое положение также объясняется тем, что Ему присущи возвышенные и величественные качества, которые никоим образом не похожи на качества творений. Более того, все творения вместе не способны всесторонне постичь даже одно из значений какого либо божественного качества. По этому поводу Всевышний сказал: «Они не способны объять Его своим знанием» (сура 20 «Та,ха »,аят 110), и это ещё раз доказывает, что ничьи качества не подобны качествам Всевышнего Аллаха. Его высокое положение проявляется в Его абсолютной власти, ибо Он — Единственный, Всемогущий. Своим могуществом и возвышенностью над всеми Он покоряет творения. Их судьбы — в Его Руках, и происходит только то, что Он пожелает, и ничто не способно помешать этому. А то, что Ему не угодно, не может произойти, и если все твари объединятся, чтобы сотворить то, что Ему не угодно, они не сумеют сделать этого. Если же они объединятся, чтобы помешать тому, что Он предрешил, то не сумеют предотвратить это. Его власть совершенна, и Его воля неизменно исполняется, и все творения испытывают в Нём всестороннюю крайнюю нужду." };
            ListOfNames["Великий"] = new Name() {One_Name = "Великий", Description = "Коран гласит: Не тяготит Его оберегание их.Он — Возвышенный, Великий. Сура 2 «Корова», аят 255. Аллах велик, и все божественные качества обязывают к почитанию и возвеличиванию Его.Ни одно творение не способно возвеличить Его должным образом, как Он того заслуживает.Он достоин похвалы, на которую способен только Он и которая недоступна Его рабам. Следует знать, что присущие Аллаху значения величия делятся на две категории. 1.Он обладает всеми качествами совершенства, и эти качества присущи Ему в самой совершенной, величественной и всеобъемлющей форме.Его знание безгранично, а могущество непререкаемо. Ему присущи гордость и величие,одним из проявлений которого является то, что небеса и земля в Пригоршне Милостивого не больше горчичного зёрнышка.Об этом говорили Ибн ‘Аббас и другие комментаторы, а Всевышний сказал: «Не ценили они Аллаха должным образом, а ведь вся земля в День воскресения будет всего лишь Пригорш­ней Его, а небеса будут свёрнуты Его Десницей» (сура 39 «Толпы», аят 67); «Воистину, Аллах удер­живает небеса и землю, чтобы они не сдвинулись. А если они сдвинутся, то никто другой после Не­го их уже не удержит» (сура 35 «Творец», аят 41); «Небеса готовы разверзнуться сверху[от величия Аллаха]» (сура 42 «Совет», аят 5). В «Сахихе» сообщается со слов Пророка , что Аллах сказал: «Гордость — Моя накидка, а величие — Мой изар, и Я подвергну мучениям того, кто попытается отнять их у Меня» [Муслим, т. 4, с. 2023; Абу Давуд, т. 4, с. 59; Ибн Маджа, т. 2, с. 1397; Ахмад, т. 2, с. 376]. Таким образом, гордость и величие — два божественных качества.Их невозможно оценить по достоинству, равно как и невозможно постичь всю глубину их смысла. 2. Ни одно из творений не достойно того, чтобы его возвеличивали и почитали так же, как Аллаха. Он заслуживает того, чтобы рабы возвеличивали Его в душе, языком и телом.Для этого следует проявить усердие в познании Его, возлюбить Его и унизиться перед Ним, смириться пред Его величавостью и убояться Его. Для этого надлежит устами прославлять Его, а телом — благодарить Его и поклоняться Ему.Чтобы почитать Аллаха, следует надлежащим образом бояться Его в делах, повиноваться Ему, не зная ослушания, поминать Его без устали, не забывать Его и быть признательным Ему, не допуская неблагодарности.Чтобы почитать Его, необходимо уважать Его запреты и предписания, касающиеся временных промежутков, мест и поступков. Всевышний сказал: «Вот так! И если кто почитает обрядовые знамения Аллаха, то это исходит от богобоязненности в сердцах» (сура 22 «Хадж», аят 32); «Вот так! Кто почитает святыни Аллаха, тот поступает во благо себе перед своим Господом» (сура 22 «Хадж», аят 30). Наконец, чтобы почитать Его, следует не возражать против того, что Он сотворил или узаконил." };
            ListOfNames["Славный"] = new Name() { One_Name = "Славный", Description = "Это — Тот, Кто обладает великой славой. Под славой подразумевается величие и необъятность качеств. Что же касается качеств Аллаха, то все они величественны и достославны. Он — Знающий, и Его знание совершенно. Он — Милосердный, и Его милосердие объемлет всё сущее. Он — Могущественный, и для Него нет ничего невозможного. Он — Выдержанный и Мудрый, а Его выдержка и мудрость безупречны. Такая характеристика справедлива по отношению ко всем божественным именам и качествам. Они достигли предела великолепия и славы, в них нет ни малейшего изъяна или недостатка. Всевышний Аллах сказал: Да пребудут над вами ми­лость и благословение Ал­лаха, о обитатели дома! Воистину, Он — Досто­хвальный, Славный. Сура 11 «Худ», аят 73" };
            ListOfNames["Большой"] = new Name() { One_Name = "Большой", Description = "Пречистому и Всевышнему Аллаху присущи слава, гордость и величие. Он больше, величавее, славнее и превыше всего сущего. Сердца Его возлюбленных и избранников преисполнены уважения и почтения к Нему. Они покорны Ему и смиренны перед Его величием, как сказал об этом Всевышний: Это потому, что, когда призывали одного Аллаха, вы не веровали. Если же к Нему приобщали сото­варищей, вы верили. Ре­шение принимает толь­ко Аллах, Возвышенный, Большой. Сура 40 «Прощающий», аят 12" };
            ListOfNames["Слышащий"] = new Name() { One_Name = "Слышащий", Description = "Всевышний сказал: Аллах — Слышащий, Ви­дящий. Сура 4 «Женщины», аят 134. Божественный слух и зрение часто упоминаются вместе. Каждое из этих качеств подразумевает обладание соответствующими внешними и внутренними способностями. Слышащий — Тот, Кто объемлет слухом всё, что можно услышать. Он слышит любые тайные и явные звуки, возникающие в высшем и низшем мирах. Он слышит их все без исключения, не запутываясь в них, несмотря на их многочисленность. Он слышит голоса на любых языках, близкие и отдалённые, приглушённые и громкие. Все они воспринимаются Им совершенно одинаково: Скрываете вы свои речи или произносите их вслух, прячетесь вы ночью или открыто передвигаетесь днём — все вы равны[перед Аллахом]. Сура 13 «Гром», аят 10. Аллах уже услышал слова женщины, которая всту­пила с тобой в пререкания относительно своего мужа и пожаловалась Аллаху. Аллах слышал ваш спор, ведь Аллах — Слышащий, Видящий. Сура 58 «Препирающаяся», аят 1 ‘Аиша говорила: «Благословен Тот, Чей слух объемлет любые звуки! Когда пререкавшаяся женщина пришла и стала жаловаться Посланнику Аллаха (да благословит его Аллах и приветствует), я находилась в углу комнаты и не могла расслышать некоторые из её слов. Аллах же ниспослал аят : “Аллах уже услышал слова женщины, которая вступила с тобой в пре­рекания относительно своего мужа”». Божественный слух бывает двух видов: а) имеется в виду, что Аллах слышит любые тайные и явные звуки, а также громкие и приглушённые голоса, различая их совершенным образом; б) имеется в виду, что Он внимает тем, кто просит Его, поклоняется Ему и обращается к Нему с молитвами. Он отвечает на их просьбы, вознаграждая их за это. Всевышний сказал: «Воистину, мой Господь внимает мольбе» (сура 14 «Ибрахим»,аят 39). Когда молящийся говорит: «Аллах внимает тому, кто восхваляет Его»[30], — имеется в виду, что Он отвечает на молитвы." };
            ListOfNames["Видящий"] = new Name() { One_Name = "Видящий", Description = "Это — Тот, Чьё зрение объемлет всё сущее в любых уголках небес и земли, даже самые крошечные творения. Он видит чёрного муравья на скале в тёмную ночь, различая все его внешние очертания и внутренние органы; от Него не скрыто даже движение пищи по его мелким органам. Он видит ток жидкости внутри ветвей деревьев и любых других растений, независимо от их размеров. Он различает сосуды муравьёв, пчёл, комаров и даже более мелких существ. Пречист Тот, Чьё величие изумляет умы, Чьи качества необъятны, а величие и проницательность совершенны. Он ведает сокровенное и явное, близкое и далёкое. Он замечает даже беглые взгляды и видит любые изменения, происходящие в сердцах. Всевышний сказал: «…Который видит те­бя, когда ты выстаиваешь намазы по ночам и двига­ешься среди падающих ниц. Воистину, Он — Слы­шащий, Знающий» (сура 26 «Поэты», аяты 218–220); «Он знает о предательском взгляде и том, что скрыва­ют сердца» (сура 40 «Прощающий», аят 19); «Аллах же — Свидетель всякой вещи!» (сура 85 «Созвездия Зодиака»,аят 9), то есть Он знает обо всём, что происходит во Вселенной, и объемлет зрением и слухом всё сущее." };
            ListOfNames["Знающий, Ведающий"] = new Name() { One_Name = "Знающий, Ведающий", Description = "Всевышний сказал: Он — Одолевающий и на­ ходится над Своими раба­ми.Он — Мудрый, Веда­ющий. Сура 6 «Скот», аят 18. Воистину, Аллах ведает о всякой вещи. Сура 8 «Трофеи», аят 75. Знающий — Тот, Чьё знание объемлет всё сущее: необходимое, невозможное и возможное. Ему известно о Себе Самом, Его пресвятых качествах и великих атрибутах. Все они есть необходимость, отсутствие которой невозможно и невероятно. Наряду с этим, Ему известно о том, что невозможно, и том, как бы это выглядело, если бы стало возможно. В Коране сказано: «Если бы на[небесах и земле] были иные божества на­ ряду с Аллахом, то[небеса и земля] разрушились бы» (сура 21 «Пророки», аят 22); «Аллах не взял Себе сына, и нет наряду с Ним другого бога. В противном случае каждый бог унёс бы с собой то, что сотворил, и одни из них возвысились бы над другими» (сура 23 «Верующие», аят 91). Эти и похожие аяты указывают на то, что Аллах ведает о том, что невозможно, и даже сообщает нам о том, что могло бы произойти, если бы это невозможное стало реальностью. Наконец, помимо всего прочего, Аллах ведает о возможном, то есть том, что существует во Вселенной, и том, чего пока нет, поскольку этого требовала божественная мудрость, но что в принципе может возникнуть. Его знания объемлют высший и низший миры, объемлют пространство и время. Ему известно всё сокрытое и явное, очевидное и сокровенное. Всевышний сказал: «Воистину, Аллах веда­ет о всякой вещи» (сура 8 «Трофеи», аят 75). Текстов о всеобъемлющем знании Аллаха очень много; всех их нельзя сосчитать и перечислить. Ничто не скроется от Него ни на земле, ни на небе, будь то крошечная крупица, или нечто большее, или нечто меньшее. Он ничего не оставляет без внимания и ничего не забывает. Все необъятные и разносторонние познания, которыми обладают творения, ничто в сравнении со знанием Аллаха. Точно так же всё могущество творений не идёт ни в какое сравнение с могуществом Господа. Он — Тот, Кто наделил их знаниями о том, чего они не ведали, и наделил их всевозможными способностями. Ему известно обо всём, что происходит на небесах и на земле, а также обо всех творениях, проживающих в этих мирах, — о них самих, их качествах, поступках и состояниях. Он ведает то, что произошло в прошлом, и то, чему предстоит произойти в далёком будущем. Он знает то, чего никогда не произойдёт, и то, как это выглядело бы, если бы всё - таки произошло. Ему известно обо всём, что происходит с людьми с того момента, как они появляются на свет, что постигает их после смерти и что ожидает их после того, как они будут воскрешены. Ни один из их добрых и злых поступков не сокрыт от Него, и в Обители вечности они получат воздаяние за свои деяния и узнают все мельчайшие подробности о самих себе. Одним словом, Аллах — Тот, Чьи знания охватывают всё зримое и незримое, тайное и явное, необходимое, невероятное и возможное. Он ведает о высшем и низшем мирах, знает о прошлом, настоящем и будущем и ничего не оставляет незамеченным." };
            ListOfNames["Достохвальный"] = new Name() { One_Name = "Достохвальный", Description = "  Всевышний сказал: О люди! Вы нуждаетесь в Аллахе, тогда как Ал­лах — Богатый, Досто­хвальный. Сура 35 «Творец», аят 15. Ибн аль-Каййим указывал на два проявления этого качества. Во-первых, все существа воздают Ему хвалу. Всевышний Аллах заслуживает всяческой похвалы, которую возносят Ему первые и последние обитатели небес и земли. Он достоин похвалы, которую возносят Ему в этом мире и в Последней жизни, и похвалы, которую только можно воздать на протяжении долгих веков. Она наполняет высший и низший миры, её невозможно ни сосчитать, ни перечислить. Аллах достоин её по праву, ведь именно Он создал творения, наделил их всяческими милостями и проливает на них зримые и незримые блага — как мирские, так и духовные. Он избавляет их от бед и несчастий. Любые милости, которыми пользуются рабы, ниспосланы от Аллаха, и только Он оберегает от зла и неприятностей. Посему Он достоин того, чтобы творения восхваляли и благодарили Его в любое время, каждое мгновение. Во-вторых, Господь достоин похвалы за то, что обладает прекрасными именами и совершенными, возвышенными качествами. Его атрибуты славны и прекрасны. Он обладает всеми качествами совершенства в их наилучших, самых величественных проявлениях. Каждое из Его качеств в отдельности заслуживает самой совершенной похвалы. Что же можно говорить о Том, Кто обладает всеми пречистыми качествами вместе?! Восхваления достойны Сам Аллах, Его атрибуты и деяния. Эти деяния преисполнены либо милости и добра, либо справедливости и мудрости, и потому их полагается хвалить наилучшим образом. Помимо того, Аллах заслуживает похвалы за то, что творит и издаёт законы, регулирующие всё происходящее во Вселенной, а также законы Шариата и справедливого возмездия в этом мире и в Последней жизни. Если говорить подробно о том, какой должна быть хвала Аллаху, и обо всём, за что Он заслуживает похвалы, то для этого не хватит ни слов, ни чернил." };
            ListOfNames["Могущественный, Всемогущий, Могучий, Способный, Всемогущий, Всесильный, Крепкий, Несокрушимый"] = new Name() { One_Name = "Могущественный, Всемогущий, Могучий, Способный, Всемогущий, Всесильный, Крепкий, Несокрушимый", Description = " Эти великие имена имеют похожий смысл, указывая на то, что Всевышний обладает совершенным могуществом, великой силой и безграничной мощью. В Коране сказано: «Могущество целиком принадлежит Аллаху» (сура 10 «Юнус», аят 65); «Воистину, твой Господь — Всесильный, Могущественный!» (сура 11 «Худ», аят 66). Таким образом, все три проявления могущества самым полным образом относятся к Великому Аллаху. Первое — сила. На это качество указывают такие имена, как Аль-Кави (Всесильный), Аль-Матин (Крепкий). Оно не может быть приписано творениям, какими бы сильными они ни были. Коран гласит: «Воистину, Аллах — Наделяющий уделом, Обладающий силой, Крепкий» (сура 51 «Рассеивающие прах», аят 58); «Ал­лах — Всемогущий. Аллах — Прощающий, Милосерд­ный» (сура 60 «Испытуемая», аят 7); «Скажи: “Он влас­тен наслать на вас мучения сверху или из-под ваших ног, или привести вас в замешательство, разделив на группировки и дав одним из вас вкусить жестокость других”» (сура 6 «Скот», аят 65); «Воистину, Аллах спо­собен на всякую вещь» (сура 18 «Пещера», аят 45); «Во­истину, богобоязненные пребудут в Райских садах и среди рек на седалище истины возле Всемогущего Властелина» (сура 54 «Луна», аяты 54–55). Второе — отсутствие всякой нужды. Аллах Самодостаточен, Он ни в ком и ни в чём не нуждается. Рабы не способны причинить Ему какой-либо вред или принести Ему какую-либо пользу. Напротив, только Он причиняет вред и приносит пользу, дарует блага одним и лишает других. Третье — власть. Аллах господствует над всеми творениями; все они подвластны Ему, подчинены Его величию, зависимы от Его воли. Он распоряжается судьбами всех существ, и они не могут ни шевельнутся, ни распорядиться тем, чем владеют, вопреки Его воле. Происходит только то, что пожелает Аллах, и то, что не угодно Ему, не может произойти. Нет силы и мощи ни у кого, кроме Него.Свидетельством Его силы и могущества было сотворение небес и земли, а также всего, что между ними, всего за шесть дней. Он дарует творениям жизнь, а потом умерщвляет их, а потом они будут воскрешены и вернутся к их Господу: «Сотворение и воскрешение всех вас подобно сотворению и воскрешению одного человека» (сура 31 «Лукман», аят 28); «Он — Тот, Кто создаёт тво­рения в первый раз, а затем воссоздаёт их, и сделать это для Него ещё легче» (сура 30 «Ромеи», аят 27). Другим свидетельством Его могущества является то, что ты видишь землю иссохшей, но стóит Ему излить с неба воду, как она приходит в движение и набухает, а потом на ней произрастают всевозможные пары растений. О Его могуществе свидетельствует участь неверующих и несправедливых народов, которые были подвергнуты различным наказаниям, ставшим поучительным уроком для остальных. Их ухищрения и уловки не принесли им пользы. Ни богатство, ни многочисленные армии, ни крепости нисколько не защитили их от Божьей кары, когда та постигла их. Напротив, всё это ещё больше отяготило их в тот момент, когда приблизилась их погибель. Колоссальная сила, которую обрели эти народы, и их изумительные изобретения были результатом того, что Аллах наделил их определёнными способностями и обучил тому, чего они не знали. Но вся эта сила, эти способности и достижения не принесли им никакой пользы, не уберегли их от наказания и погибели, и это стало ещё одним знамением Аллаха. Они пытались спастись от лютой кары, но свершилось Божье веление, ибо всё сущее на небесах и на земле подчинено Его воле. На совершенство могущества и власти Аллаха также указывает сотворение Им деяний рабов, их богоугодных поступков и грехов. Аллах сотворил не только рабов, но и их деяния. Таким образом, поступки и действия людей сотворены и предопределены Господом, но совершаются самими людьми. Между этими истинами нет противоречий, ибо Аллах создал их способности и волю. Тот, Кто создал причины, также является создателем того, что вызывает эти причины. В Коране сказано: «Аллах сотворил вас и то, что вы делаете» (сура 37 «Выстроившиеся в ряды», аят 96). Ещё одним проявлением Его могущества является упомянутое в Коране обещание помогать праведникам и приближённым рабам (аулийа), несмотря на их малочисленность и слабую оснащённость, в борьбе с врагами, превосходящими их числом и умением. Всевышний сказал: «Сколько малочисленных отрядов победило многочисленные отряды по воле Аллаха!» (сура 2 «Корова», аят 249). Благодаря Своему могуществу и по милости Своей Аллах приготовил для обитателей Ада и Рая разные виды наказания и вечного удовольствия, которые не прервутся и не прекратятся. Благодаря Своему могуществу Господь сотворил всё сущее, управляет Своими творениями, придаёт им соразмерность и совершенный облик, оживляет мёртвых и умерщвляет живых, а потом воскресит рабов для того, чтобы они получили воздаяние, вознаградит праведников за их благодеяния и покарает грешников за их прегрешения. Он изменяет состояние сердец и направляет их туда, куда пожелает: «Когда Он желает чего-либо, то стоит Ему сказать: “Будь!” — как это сбы­вается» (сура 36 «Йа, син», аят 82); «Где бы вы ни были, Аллах приведёт всех вас вместе. Воистину, Аллах спо­собен на всякую вещь» (сура 2 «Корова», аят 148)." };
            ListOfNames["Богатый"] = new Name() { One_Name = "Богатый", Description = "Всевышний сказал: Он дарует богатство и на­деляет собственностью. Сура 53 «Звезда», аят 48. О люди! Вы нуждаетесь в Аллахе, тогда как Ал­лах — Богатый, Досто­хвальный. Сура 35 «Творец», аят 15. Он богат и абсолютно ни в чём не нуждается, ибо Он обладает совершенством, и все Его качества совершенны и далеки от малейших недостатков. Бог не может нуждаться в чём-либо, ибо Его богатство и самодостаточность являются необходимостью. Таким же образом, Бог непременно должен быть Добродетельным, Щедрым, Добрым, Милосердным, Великодушным. Творения не способны прожить без Его заботы даже мгновение ока. Их появление на свет и существование невозможны без Его участия. Они нуждаются в Нём для удовлетворения своих нужд и потребностей. Проявлением Его безмерного богатства является обладание Им сокровищницами небес и земли, а также сокровищницами великой милости. Он неустанно оказывает милость Его творениям: каждый миг они пользуются Его благами. Он одаряет их днём и ночью, щедро и не скупясь. Совершенство богатства и щедрости Аллаха проявляется и в Его повелении взывать к Нему. Он обещал Своим рабам отвечать на их молитвы и удовлетворять их просьбы. Он наделяет их благами, которые они просят, и многим из того, чего они даже не просят. Его богатство настолько совершенно, что если все творения, от первого до последнего, соберутся в одном месте и попросят Его о любых благах, и Он одарит их тем, что они попросят, и всем, что только придёт им на ум, то от этого Его богатство не уменьшится даже на малую толику. Свидетельством безграничности Его богатства являются удовольствия и нескончаемые радости, которыми Он щедро одарит обитателей Рая. Это будут бесконечные дары, которых не видывал взор, о которых не слышали уши, которые даже не приходили на ум человеку. Ещё одним проявлением Его абсолютного богатства является отсутствие у Него жены и детей. Никто не разделяет с Ним божественной власти, и Он не нуж- дается в покровителе, избавляющем от унижения. Он богат и самодостаточен благодаря Своим совершенным качествам, и Он — Тот, Кто избавляет творения от нужды. Одним словом, Аллах самодостаточен и обладает всесторонним и абсолютным богатством, вследствие чего Он ни в чём не нуждается. Он дарует достаток всем творениям в самом широком смысле и одаряет особым достатком Своих избранников, наполняя их сердца божественным знанием и верой." };

            ListOfNames["Мудрый"] = new Name() { One_Name = "Мудрый", Description = "Всевышний сказал: Он — Одолевающий и нахо­дится над Своими рабами. Он — Мудрый, Ведающий. Сура 6 «Скот», аят 18. Это значит, что Он обладает безупречной мудростью и совершенной властью. Мудрый — Тот, Кто обладает всесторонними знаниями о сути событий и их исходе, последствиях, Кто заслуживает щедрой похвалы, обладает совершенным могуществом и необъятным милосердием. Он всё расставляет по местам, творит только то, что заслуживает быть, и отдаёт только подобающие приказы. В Его мудрости нельзя усомниться, и её нельзя подвергнуть критике. Следует знать, что божественная мудрость проявляется в двух формах. Первая — мудрость в творении. Аллах создал всё сущее с истиной и ради неё. Истина была целью появления творений на свет. Он установил во Вселенной прекрасный порядок и придал каждому существу надлежащий вид. Более того, Он позаботился о каждом органе живых существ и каждой части Его творений, и ни в одном из них нельзя усмотреть несовершенство или изъян. И если даже лучшие умы всех времён и народов объединятся, чтобы придумать нечто подобное творению Милостивого или хотя бы нечто близкое к этому прекрасному порядку и изумительному совершенству, у них ничего не выйдет. Они не способны на такое, и самые мудрые и рассудительные из мужей довольствуются лишь тем, что постигают некоторые из Божьих законов. Они могут видеть лишь часть того изящества и совершенства, которое заложено в творении Аллаха. Всё это вытекает с полной очевидностью из Его величия и совершенства Его качеств, из Его многочисленных творений и велений. Поэтому Он бросил вызов рабам, приказав им внимательно наблюдать за Его творением, выискивая в нём изъяны и недостатки. Он же сообщил, что человек скорее устанет наблюдать за Божьими созданиями, чем найдёт в них то, к чему можно придраться. Вторая — мудрость в законах и повелениях. Всевышний установил законы, ниспослал Писания и отправил посланников, чтобы рабы познали Его и поклонялись Ему. Может ли быть более мудрая цель? Может ли быть большая милость? Познание Всевышнего Аллаха, поклонение Ему одному, не приобщая сотоварищей к Нему, искреннее служение Ему, возможность благодарить и восхвалять Его — лучшее и самое славное из того, чем Аллах наделил Своих рабов. Это — наивысшее счастье и радость для человеческих сердец и душ. Вместе с тем это — единственный способ обрести вечное счастье и бесконечное блаженство. Эта великая цель — основа всякого благополучия и наивысшее удовольствие. Ради неё было создано всё сущее, ради неё были сотворены Рай и Ад, и ради неё будет вершиться справедливое возмездие. И если бы она была единственной целью ниспослания Божьих приказов и законов, то этого было бы вполне достаточно. Шариат Аллаха и Его религия преисполнены всякого блага. Его повествования наполняют сердца знаниями, убеждённостью и верой. Правильные убеждения выправляют кривизну человеческих душ, воплощаются в прекрасные нравственные качества и праведные деяния, помогают следовать прямым путём. Приказы и запреты Аллаха исполнены высшей мудрости, они служат исправлению духовного и материального мира, ибо Господь приказывает только то, что приносит одну только пользу или приносит больше пользы, чем вреда. А Его запреты распространяются только на то, что приносит один только вред либо приносит больше вреда, чем пользы. Мудрость мусульманского Шариата не ограничивается тем, что он нацелен на оздоровление душ, исправление нравов и поступков, а также следование прямым путём. Напротив, Шариат содержит законы, необходимые для приведения в порядок и мирских дел. Более того, подлинного благополучия на земле можно достичь, только следуя предписаниям истинной религии, принесённой Пророком Мухаммадом (да благословит его Аллах и приветствует). Это очевидно для каждого благоразумного человека, ибо последователи Мухаммада (да благословит его Аллах и приветствует) жили в полном благополучии, пока они руководствовались основными и второстепенными предписаниями этой религии, прислушивались ко всем её наставлениям и указаниям. Когда же они отклонились от этого пути и отказались от выполнения многих из этих канонов, когда они перестали руководствоваться высоким учением ислама, их мирская жизнь тоже пришла в упадок. Посмотри на другие народы, обладающие могучей силой и добившиеся изумительных успехов в цивилизационном развитии. Они лишены живительного духа веры, её милости и справедливости, и поэтому своими действиями они приносят больше вреда, чем пользы. Их учёные, правители и политики не способны предотвратить распространения зла, которое несёт с собой их развитие, и они не смогут справиться с такой задачей, пока не исправят своего положения. Вот почему божественная мудрость требовала, чтобы принесённая Мухаммадом (да благословит его Аллах и приветствует) религия и Священный Коран были ярчайшими свидетельствами его правдивости и справедливости его учения. Одним словом, Мудрый — Тот, Чья мудрость проявляется в Его творениях и велениях, каждое из которых совершенно и прекрасно. Он обладает тремя формами власти, которыми не обладает никто другой: вершит судьбу рабов по законам Шариата, предопределения и справедливого возмездия. Следует различать между законами предопределения и Шариата. Первые связаны с тем, что Господь предопределил и сотворил. В соответствии с ними происходит только то, что пожелал Аллах, а то, что не угодно Ему, не происходит. А законы Шариата связаны с тем, что Аллах приказал. Творения обязательно подчиняются либо одной группе этих законов, либо им обеим. Тот, кто совершает богоугодные поступки, подчиняется как законам предопределения, так и законам Шариата. Тот же, кто поступает иначе, попадает под законы предопределения. Его судьба была предопределена и предрешена, но он не следовал законам Шариата, отказавшись от того, что угодно Аллаху и нравится Ему. Таким образом, добро и зло, благодеяния и грехи — всё это происходит строго в соответствии с Божьим предопределением. А те из этих поступков, которые угодны Аллаху и нравятся Ему, также соответствуют законам Его Шариата и всему, что вытекает из них." };
            ListOfNames[""] = new Name() { One_Name = "", Description = "" };
            ListOfNames[""] = new Name() { One_Name = "", Description = "" };
            ListOfNames[""] = new Name() { One_Name = "", Description = "" };
            ListOfNames[""] = new Name() { One_Name = "", Description = "" };
            ListOfNames[""] = new Name() { One_Name = "", Description = "" };
            ListOfNames[""] = new Name() { One_Name = "", Description = "" };
            ListOfNames[""] = new Name() { One_Name = "", Description = "" };
            ListOfNames[""] = new Name() { One_Name = "", Description = "" };
            ListOfNames[""] = new Name() { One_Name = "", Description = "" };
            ListOfNames[""] = new Name() { One_Name = "", Description = "" };
            ListOfNames[""] = new Name() { One_Name = "", Description = "" };
            ListOfNames[""] = new Name() { One_Name = "", Description = "" };
            ListOfNames[""] = new Name() { One_Name = "", Description = "" };
                }

    }
}