# Email Service

```sql
CREATE TABLE users (
    user_id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    email VARCHAR(255) UNIQUE NOT NULL,
    created_at TIMESTAMPTZ DEFAULT NOW(),
    updated_at TIMESTAMPTZ DEFAULT NOW()
);

CREATE TABLE templates (
    template_id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    name VARCHAR(255) NOT NULL,
    subject VARCHAR(255) NOT NULL,
    content TEXT NOT NULL,
    is_predefined BOOLEAN DEFAULT FALSE,
    user_id UUID REFERENCES users(user_id) ON DELETE CASCADE,
    parent_id UUID REFERENCES templates(template_id) ON DELETE SET NULL,
    created_at TIMESTAMPTZ DEFAULT NOW(),
    updated_at TIMESTAMPTZ DEFAULT NOW(),
    CHECK (
        (is_predefined AND user_id IS NULL) OR 
        (NOT is_predefined AND user_id IS NOT NULL)
    )
);

CREATE TABLE template_fields (
    field_id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    template_id UUID NOT NULL REFERENCES templates(template_id) ON DELETE CASCADE,
    field_key VARCHAR(255) NOT NULL,
    default_value TEXT,
    created_at TIMESTAMPTZ DEFAULT NOW(),
    UNIQUE(template_id, field_key)
);

CREATE TABLE emails (
    email_id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    template_id UUID REFERENCES templates(template_id) ON DELETE SET NULL,
    user_id UUID NOT NULL REFERENCES users(user_id) ON DELETE CASCADE,
    sender_email VARCHAR(255) NOT NULL,
    recipient_email VARCHAR(255) NOT NULL,
    subject VARCHAR(255) NOT NULL,
    content TEXT NOT NULL,
    sent_at TIMESTAMPTZ DEFAULT NOW(),
    status VARCHAR(50) DEFAULT 'pending'
);

CREATE TABLE email_fields (
    email_field_id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    email_id UUID NOT NULL REFERENCES emails(email_id) ON DELETE CASCADE,
    field_key VARCHAR(255) NOT NULL,
    field_value TEXT NOT NULL,
    created_at TIMESTAMPTZ DEFAULT NOW()
);

```

```sql
SELECT * FROM templates 
WHERE user_id = :user_id
OR (is_predefined AND NOT EXISTS (
    SELECT 1 FROM templates 
    WHERE parent_id = templates.template_id 
    AND user_id = :user_id
))
```