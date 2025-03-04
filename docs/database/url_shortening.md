# Url Shortening 

```sql
CREATE TABLE users (
    user_id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    email VARCHAR(255) UNIQUE NOT NULL,
    password_hash TEXT NOT NULL,
    created_at TIMESTAMPTZ DEFAULT NOW(),
    is_premium BOOLEAN DEFAULT FALSE
);

CREATE TABLE short_urls (
    short_url_id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    original_url TEXT NOT NULL,
    short_code VARCHAR(20) UNIQUE NOT NULL,
    user_id UUID REFERENCES users(user_id) ON DELETE CASCADE,
    created_at TIMESTAMPTZ DEFAULT NOW(),
    expires_at TIMESTAMPTZ,
    is_active BOOLEAN DEFAULT TRUE,
    click_count INT DEFAULT 0,
    last_clicked_at TIMESTAMPTZ
);

CREATE TABLE clicks (
    click_id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    short_url_id UUID NOT NULL REFERENCES short_urls(short_url_id) ON DELETE CASCADE,
    ip_address INET,
    user_agent TEXT,
    referrer TEXT,
    country_code CHAR(2),
    device_type VARCHAR(20),
    created_at TIMESTAMPTZ DEFAULT NOW()
);

-- For custom short URLs (premium feature)
CREATE TABLE custom_aliases (
    alias VARCHAR(50) PRIMARY KEY,
    short_url_id UUID NOT NULL REFERENCES short_urls(short_url_id) ON DELETE CASCADE,
    created_at TIMESTAMPTZ DEFAULT NOW()
);

-- For URL expiration and scheduling
CREATE TABLE url_schedules (
    short_url_id UUID PRIMARY KEY REFERENCES short_urls(short_url_id) ON DELETE CASCADE,
    start_time TIMESTAMPTZ,
    end_time TIMESTAMPTZ,
    max_clicks INT
);

-- For analytics aggregation
CREATE TABLE daily_stats (
    stat_date DATE,
    short_url_id UUID REFERENCES short_urls(short_url_id) ON DELETE CASCADE,
    total_clicks INT DEFAULT 0,
    unique_visitors INT DEFAULT 0,
    PRIMARY KEY (stat_date, short_url_id)
);
```