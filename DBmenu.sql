PGDMP         ;                z            PBO    14.5    14.5 	    ?           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            ?           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ?           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            ?           1262    24576    PBO    DATABASE     i   CREATE DATABASE "PBO" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United States.1252';
    DROP DATABASE "PBO";
                postgres    false            ?            1259    32794    menu    TABLE     ?   CREATE TABLE public.menu (
    id integer NOT NULL,
    nama character varying(25) NOT NULL,
    harga integer NOT NULL,
    kategori character varying(25) NOT NULL
);
    DROP TABLE public.menu;
       public         heap    postgres    false            ?            1259    32793    menu_id_seq    SEQUENCE     ?   ALTER TABLE public.menu ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.menu_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    210            ?          0    32794    menu 
   TABLE DATA           9   COPY public.menu (id, nama, harga, kategori) FROM stdin;
    public          postgres    false    210   V       ?           0    0    menu_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.menu_id_seq', 17, true);
          public          postgres    false    209            ]           2606    32798    menu menu_pkey 
   CONSTRAINT     L   ALTER TABLE ONLY public.menu
    ADD CONSTRAINT menu_pkey PRIMARY KEY (id);
 8   ALTER TABLE ONLY public.menu DROP CONSTRAINT menu_pkey;
       public            postgres    false    210            ?   ?   x?m??N?@???W?T3M?`?T??%`???%K???g??2Uw???l?r/N?0??Z?κ?'?lPuT?j'?#sl?⛉P.?9r'V???g????]f4z?%??[u#???Ǩ%?*L?e2?O???\b??n?l?Y?ڇo?Q;œ?VU!=?????vߴ???>?[s?g????<??!*݌Y?*~??????$I? ?SvX     